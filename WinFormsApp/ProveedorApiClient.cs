using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    internal class ProveedorApiClient
    {
        private static HttpClient client = new HttpClient();
        static ProveedorApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7092/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Proveedor> GetAsync(int id)
        {
            Proveedor proveedor = null;
            HttpResponseMessage response = await client.GetAsync("proveedores/" + id);
            if (response.IsSuccessStatusCode)
            {
                proveedor = await response.Content.ReadAsAsync<Proveedor>();
            }
            return proveedor;
        }

        public static async Task<IEnumerable<Proveedor>> GetAllAsync()
        {
            IEnumerable<Proveedor> proveedors = null;
            HttpResponseMessage response = await client.GetAsync("proveedores");
            if (response.IsSuccessStatusCode)
            {
                proveedors = await response.Content.ReadAsAsync<IEnumerable<Proveedor>>();
            }
            return proveedors;
        }

        public static async Task UpdateAsync(Proveedor proveedor)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("proveedores", proveedor);
            response.EnsureSuccessStatusCode();
        }

        public async static Task AddAsync(Proveedor proveedor)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("proveedores", proveedor);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("proveedores/" + id);
            response.EnsureSuccessStatusCode();
        }
    }
}
