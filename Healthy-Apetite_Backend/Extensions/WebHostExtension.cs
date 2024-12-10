namespace Healthy_Apetite_Backend.Extensions
{
    public static class WebHostExtension
    {
        public static void ConfigureWebHost(this WebApplicationBuilder webApplicationBuilder)
        {
            webApplicationBuilder.WebHost.UseUrls("https://0.0.0.0:7020");
        }
    }
}
