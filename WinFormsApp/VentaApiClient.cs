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
        public static async Task<Venta> GetAsync(int id)
        {
            Venta venta = null;
            HttpResponseMessage response = await client.GetAsync("ventas/" + id);
            if (response.IsSuccessStatusCode)
            {
                venta = await response.Content.ReadAsAsync<Venta>();
            }
            return venta;
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
        public static async Task UpdateAsync(Venta venta)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("ventas", venta);
            response.EnsureSuccessStatusCode();
        }
        public async static Task AddAsync(Venta venta)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("ventas", venta);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("ventas/" + id);
            response.EnsureSuccessStatusCode();
        }
    }
}
