using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Tesis.API.Controllers;
using Tesis.API.GraphQL;

namespace Tests
{
    public abstract class BaseApiTest
    {

        public void Init()
        {
            TestServer server = new TestServer(new WebHostBuilder()).UseEnvironment("");
            HttpClient client = server.CreateClient();
        }
    }
}
