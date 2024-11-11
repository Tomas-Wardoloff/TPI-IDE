using Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    internal class MaquinariaApiClient
    {
        private static HttpClient client = new HttpClient();
        static MaquinariaApiClient()
        {
            client.BaseAddress = new Uri("https://localhost:7092/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Maquinaria> GetAsync(int id)
        {
            Maquinaria maquinaria = null;
            HttpResponseMessage response = await client.GetAsync("maquinarias/" + id);
            if (response.IsSuccessStatusCode)
            {
                maquinaria = await response.Content.ReadAsAsync<Maquinaria>();
            }
            return maquinaria;
        }

        public static async Task<IEnumerable<Maquinaria>> GetAllAsync()
        {
            IEnumerable<Maquinaria> maquinarias = null;
            HttpResponseMessage response = await client.GetAsync("maquinarias");
            if (response.IsSuccessStatusCode)
            {
                maquinarias = await response.Content.ReadAsAsync<IEnumerable<Maquinaria>>();
            }
            return maquinarias;
        }

        public static async Task UpdateAsync(Maquinaria maquinaria)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync("maquinarias", maquinaria);
            response.EnsureSuccessStatusCode();
        }

        public async static Task AddAsync(Maquinaria maquinaria)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync("maquinarias", maquinaria);
            response.EnsureSuccessStatusCode();
        }

        public static async Task DeleteAsync(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync("maquinarias/" + id);
            response.EnsureSuccessStatusCode();
        }
    }
}
}
