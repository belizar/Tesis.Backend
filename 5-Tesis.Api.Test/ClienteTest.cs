using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using NUnit.Framework;
using System.Net.Http;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            TestServer server = new TestServer(new WebHostBuilder());
            HttpClient client = server.CreateClient():;
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}