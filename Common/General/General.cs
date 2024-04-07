#nullable disable
using Microsoft.Extensions.Configuration;

namespace Common.Genral;

public static class General
{
    public static IConfigurationRoot Configuration;
    public static string GetConfigurationValue(string section)
    {
        var builder = new ConfigurationBuilder().SetBasePath(System.IO.Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
        Configuration = builder.Build();
        var connectionString = Configuration.GetSection(section).Value.ToString();
        return connectionString;
    }
}
