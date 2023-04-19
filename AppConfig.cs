﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK2EVERYONE
{
    public static class AppConfig
    {
        private static IConfiguration _iconfiguration;
        static AppConfig()
        {
            GetAppSttingsFile();
        }

        public static void GetAppSttingsFile()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsetings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        public static string GetConnectionStringSourceSql()
        {
            return _iconfiguration.GetConnectionString("SourceSqlDb");
        }
        public static string GetConnectionStringFirebird()
        {
            return _iconfiguration.GetConnectionString("FirebirdDb");
        }
    }
}
