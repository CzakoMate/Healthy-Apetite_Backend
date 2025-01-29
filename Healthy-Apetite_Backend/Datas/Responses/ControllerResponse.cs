namespace Healthy_Apetite_Backend.Datas.Responses
{
    public class ControllerResponse: ErrorStore
    {
        public ControllerResponse():base(){}
        public bool IsSucces => !HasError;
    }
}
