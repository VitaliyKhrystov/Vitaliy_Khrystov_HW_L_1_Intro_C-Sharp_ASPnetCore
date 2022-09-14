using Microsoft.AspNetCore.Builder;

namespace Task_1
{
    public class Startup
    {
        public IConfiguration configRoot
        {
            get;
        }
        public Startup(IConfiguration configuration)
        {
            configRoot = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddMvc();
        }

        public void Configure(WebApplication app, IWebHostEnvironment env)
        {
           
            app.UseStaticFiles();
            app.UseRouting();
            app.UseMvc();
            app.MapRazorPages();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
