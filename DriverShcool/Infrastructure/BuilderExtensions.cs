namespace DriverShcool.Infrastructure
{
    public static class BuilderExtensions
    {
        public static void Configure(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllersWithViews();
        }
    }
}
