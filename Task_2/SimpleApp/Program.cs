using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace SimpleApp
{

    //Задание 1.
    //Доработайте приложение SimpleApp.В файл data.txt добавьте дополнительную информацию о
    //продукте – описание продукта, количество единиц на складе.
    //Добавьте в представление Details описание продукта и количество единиц на складе.
    //В представлении List сделайте так, чтобы если продукта на складе нет, отображалось сообщение
    //напротив продукта - «нет в наличии», если количество до 5 единиц на складе – «заканчивается», 
    //если более 5 единиц – «в наличии».


    //Задание 2.
    //Сделайте так, чтобы в приложении SimpleApp по адресу Home/Index возвращалось
    //представление.Сделайте в этом представлении ссылку «Скачать описание урока». При клике на
    //ссылку должен скачиваться этот файл

    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
