using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public static class GraphQlExtensions
    {
        public static async Task<JObject> GetGraphQLAsync(this HttpClient @this, string request)
        {
            var response = await @this.PostAsync("/graphql/", new StringContent(request, Encoding.UTF8, "application/json"));
            return await response.Content.ReadAsAsync<JObject>();
        }

    }
}
