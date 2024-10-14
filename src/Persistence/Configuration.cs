using Microsoft.Extensions.Configuration;

namespace Persistence
{
    internal static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../WebAPI"));
                configurationManager.AddJsonFile("appsettings.Development.json");
                return configurationManager.GetConnectionString("Default");
            }
        }
    }
}