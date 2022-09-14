namespace Task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //������� 1 (Additional Task)
            //�������� ������ ASP.NET Core ����������.������� � ���� ������ ���������, ���
            //������������� MVC.�������� ����������� ��������� � �������, ����� ��� �������
            /// Test / Message ������������ �������� � ���������� �Hello world�, � ��� ������� List / Info -
            //����������� ������<ul> � ����� ���������� � ������������ �������.

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