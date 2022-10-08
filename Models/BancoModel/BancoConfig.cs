using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace Models.BancoModel
{
    public class BancoConfig
    {
        public static IConfigurationRoot Configuration { get; set; }

        public static string GetConexao()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            return Configuration["ConnectionStrings:DefaultConnection"];
        }
    }
}
