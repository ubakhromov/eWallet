using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace eWallet.Api
{
    internal class Program
    {
        private static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                webBuilder.UseStartup<Startup>());
        }

    }
}