using Healthy_Apetite_Backend.Context;
using Healthy_Apetite_Backend.Extensions;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddBackend();
builder.ConfigureWebHost();
var app = builder.Build();

// InMemory database data
using (var scope = app.Services.CreateAsyncScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<HealthyApetiteInMemoryContext>();

    // InMemory test data
    dbContext.Database.EnsureCreated();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("HealthyApetiteCors");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.ConfigureWebApplication();

app.Run();
