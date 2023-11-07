using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

namespace Common.Genral
{
    public class General
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
}
