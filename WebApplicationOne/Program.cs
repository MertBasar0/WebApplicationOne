using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationOne
{
    public class Program
    {
        //Asp.net core uygulamaları özünde bir console uygulamasıdır.
        //Asp.net core kendi dahilinde sunucu barındırır dedik. İste o sunucuyu ayağa kaldırıldığı yer program.cs dosyasıdır.
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        //İçerisinde gömülü olan host'un kullanacağı konfigürasyonları nerden alacağını bildirmektedir.
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                    //Burada temel konfigürasyon ayarları yağıldığı yer startup classıdır.
                });
    }
}
