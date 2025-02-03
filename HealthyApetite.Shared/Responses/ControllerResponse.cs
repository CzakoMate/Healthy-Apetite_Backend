namespace HealthyApetite.Shared.Responses
{
    public class ControllerResponse : ErrorStore
    {
        public ControllerResponse() : base() { }
        public bool IsSucces => !HasError;
    }
}
