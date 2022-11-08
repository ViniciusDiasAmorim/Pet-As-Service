using Newtonsoft.Json;
using PetAsService.Models;

namespace PetAsService.Services
{
    public class CatService
    {
        public async Task<Cat> GetCat(string id)
        {
            string parametro = id;

            string url = $"https://api.thecatapi.com/v1/breeds/{id}";

            HttpClient client = new HttpClient { BaseAddress = new Uri(url) };

            var response = await client.GetAsync(parametro);

            var content = await response.Content.ReadAsStringAsync();

            var cat = JsonConvert.DeserializeObject<Cat>(content);
           
            return cat;
        }
    }
}
