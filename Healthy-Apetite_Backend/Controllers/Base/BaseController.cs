using Healthy_Apetite_Backend.Repos.Base;
using HealthyApetite.Shared.Assemblers;
using HealthyApetite.Shared.Models;
using HealthyApetite.Shared.Responses;
using Microsoft.AspNetCore.Mvc;

namespace Healthy_Apetite_Backend.Controllers.Base
{
    public abstract class BaseController<TModel,TDto> : ControllerBase
        where TModel : class,IDbEntity<TModel>,new()
        where TDto : class, new()
    {
        protected Assambler<TModel,TDto> _assambler;
        protected IBaseRepo<TModel> _repo;

        public BaseController(Assambler<TModel, TDto>? assambler, IBaseRepo<TModel>? repo)
        {
            _assambler = assambler ?? throw new ArgumentNullException(nameof(assambler));
            _repo = repo ?? throw new ArgumentNullException(nameof(repo));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(Guid id)
        {
            var entity = (await _repo.FindByConditionAsync(s => s.Id == id)).FirstOrDefault();
            if (entity != null)
                return Ok(_assambler.ToDto(entity));
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var entities = (await _repo.GetAllAsync()).ToList();
            return Ok(entities.Select(e => _assambler.ToDto(e)));
        }

        [HttpPut()]
        public async Task<ActionResult> UpdateAsync(TDto entitiyDto)
        {
            ControllerResponse response = response = await _repo.UpdateAsync(_assambler.ToModel(entitiyDto));
            if (response.HasError)
            {
                Console.WriteLine(response.Error);
                response.ClearAndAddError("Az entitás adatainak módosítása nem sikerült!");
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(Guid id)
        {
            ControllerResponse response = await _repo.DeleteAsync(id);
            if (response.HasError)
            {
                Console.WriteLine(response.Error);
                response.ClearAndAddError("A entitás adatainak törlése nem sikerült!");
                return BadRequest(response);
            }
            return Ok(response);
        }

        [HttpPost()]
        public async Task<IActionResult> CreateAsync(TDto entityDto)
        {
            ControllerResponse response = await _repo.CreateAsync(_assambler.ToModel(entityDto));
            if (response.HasError)
            {
                Console.WriteLine(response.Error);
                response.ClearAndAddError("Új entitáts adatának felvétele nem sikerült!");
                return BadRequest(response);
            }
            else
                return Ok(response);
        }
    }
}
