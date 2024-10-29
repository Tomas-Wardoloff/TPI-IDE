using Domain.Model;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace WinFormsApp
{
    internal class VentaApiClient
    {
        private static HttpClient client = new HttpClient();

        static VentaApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7092/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<IEnumerable<Venta>> GetAllAsync()
        {
            IEnumerable<Venta> ventas = null;
            HttpResponseMessage response = await client.GetAsync("ventas");
            if (response.IsSuccessStatusCode)
            {
                ventas = await response.Content.ReadAsAsync<IEnumerable<Venta>>();
            }
            return ventas;
        }
    }
}
