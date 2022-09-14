namespace Task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Задание 1 (Additional Task)
            //Создайте пустое ASP.NET Core приложение.Внесите в него нужные изменения, для
            //использования MVC.Сделайте необходимые изменения в проекте, чтобы при запросе
            /// Test / Message отображалась страница с сообщением «Hello world», а при запросе List / Info -
            //отображался список<ul> с тремя элементами и произвольным текстом.

            CreateHostBuilder(args).Build().Run();
            //var builder = WebApplication.CreateBuilder(args);
            //var startup = new Startup(builder.Configuration);
            //startup.ConfigureServices(builder.Services); // calling ConfigureServices method
            //var app = builder.Build();
            //startup.Configure(app, builder.Environment); // calling Configure method
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}