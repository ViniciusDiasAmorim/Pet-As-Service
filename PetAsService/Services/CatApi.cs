using Newtonsoft.Json;
using PetAsService.Models;
using System.Diagnostics;

namespace PetAsService.Services
{
    public class CatApi
    {
        public async Task<Cat> GetCat()
        {

            string url = "https://api.thecatapi.com/v1/breeds";

            string id = "beng";

            string parametro = $"/{id}";

            HttpClient client = new HttpClient { BaseAddress = new Uri(url) };

            var response = await client.GetAsync(parametro);

            var content = await response.Content.ReadAsStringAsync();

            var cat = JsonConvert.DeserializeObject<Cat>(content);

            return cat;

        }
    }
}
