using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace SK2EVERYONE
{
    public class AppConfig
    {
        static IHost host = Host.CreateDefaultBuilder().Build();
        static IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

        public static string GetConnectionStringSourceSql()
        {
            //return config.GetConnectionString("SourceSqlDb");
            return config["ConnectionStrings:SourceSqlDb"];
        }
        public static string GetConnectionStringFirebird()
        {
            //return config.GetConnectionString("FirebirdDb");
            return config["ConnectionStrings:FirebirdDb"];
        }
    }
}
