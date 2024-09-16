using Domain.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WinFormsApp
{
    internal class ClienteApiClient
    {
        private static HttpClient client = new HttpClient();
        static ClienteApiClient()
        {
            client.BaseAddress = new Uri("http://localhost:5183/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<IEnumerable<Cliente>> GetAllAsync()
        {
            IEnumerable<Cliente> clientes = null;
            HttpResponseMessage response = await client.GetAsync("clientes");
            if (response.IsSuccessStatusCode)
            {
                clientes = await response.Content.ReadAsAsync<IEnumerable<Cliente>>();
            }
            return clientes;
        }
    }
}
