﻿using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Inspiro.Helper
{
    public class ConnectionSettings
    {
        public string conSql { get; set; }

        public ConnectionSettings()
        {
            var configuration = GetConfiguration();
            conSql = configuration.GetSection("ConnectionStrings").GetSection("Default").Value;
        }

        public IConfigurationRoot GetConfiguration()
        {
            var builder = new ConfigurationBuilder().SetBasePath(
                Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json",
                    optional: true, reloadOnChange: true);
            return builder.Build();
        }
    }
}
