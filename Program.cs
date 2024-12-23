using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace TTR_CRM
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // HostBuilder kullanımı
            CreateHostBuilder(args).Build().Run();
        }

        // ASP.NET Core uygulaması için host oluşturur
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    // Startup.cs dosyasını işaret eder
                    webBuilder.UseStartup<Startup>();
                });
    }
}
