namespace Healthy_Apetite_Backend.Extensions
{
    public static class WebApplicationExtension
    {
        public static void ConfigureWebApplication(this WebApplication webApplication)
        {
            webApplication.UseCors("HealthyApetiteCors");
        }
    }
}
