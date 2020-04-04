using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Tesis.API;
using Xunit;

namespace Tesis.Api.Test
{
    public class UnitTest1
    {
        private HttpClient client;

        [Fact]
        public void Test1()
        {
            var server = new TestServer(new WebHostBuilder().UseEnvironment("testing")
                                                            .UseStartup<Startup>());
            client = server.CreateClient();
        }
    }
}
