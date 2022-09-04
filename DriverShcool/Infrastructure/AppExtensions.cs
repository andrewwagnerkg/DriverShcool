namespace DriverShcool.Infrastructure
{
    public static class AppExtensions
    {
        public static void Configure(this WebApplication app)
        {
            app.UseStaticFiles();
            ConfigureRouting(app);
        }

        private static void ConfigureRouting(WebApplication app)
        {
            app.MapGet("/", () => "It works");
        }
    }
}
