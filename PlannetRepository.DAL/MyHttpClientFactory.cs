using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace PlannetRepository.DAL
{
    internal static class HttpClientFactory
    {
        static HttpClient client;

        internal static HttpClient GetClient()
        {
            if (client == null)
            {
                client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:3000");
            }

            return client;
        }
    }
}
