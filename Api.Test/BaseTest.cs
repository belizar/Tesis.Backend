using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Tesis.API;

namespace Tests
{
    public class BaseTest
    {
        public HttpClient client { get; private set; }

        [SetUp]
        public async Task Setup()
        {
            string curDir = Directory.GetCurrentDirectory();

            var server = new TestServer(new WebHostBuilder().UseContentRoot(curDir)
                                                            .UseStartup<Startup>()
                                                            .UseConfiguration(new ConfigurationBuilder().AddJsonFile("appsettings.json")
                                                                                                        .Build())
                                                            );
            client = server.CreateClient();
        }
    }
}
