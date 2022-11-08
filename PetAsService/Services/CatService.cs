using Newtonsoft.Json;
using PetAsService.Models;
using System.Text;

namespace PetAsService.Services
{
    public class CatService
    {
        public string image_id { get; set; }
        public string sub_id { get; set; }
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

        public async Task<string> FavCat(Cat cat)
        {
            using HttpClient client = new HttpClient();

            string apiKey = "live_2bP4Aft5O3yEca6knhta8iRtWCky03uCofrQr2f6l5R3j98P7WSS6WSlUxjsmOyh";

            var catPost = new CatService()
            {
                image_id = $"{cat.ReferenceImageId}",
                sub_id = $"user-123"
            };

            var teste = JsonConvert.SerializeObject(catPost);

            var data = new StringContent(teste, Encoding.UTF8, "application/json");

            var url = $"https://api.thecatapi.com/v1/favourites?api_key={apiKey}";

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;

            if(response.IsSuccessStatusCode)
            {
                return  $"{cat.Name} favoritado com sucesso !!";
            }

            return $"Ocorreu um problema em favoritar o {cat.Name} talvez voce ja tenha favoritado ele.";
        }

        public async Task<List<CatService>> GetFavCat()
        {
            string url = "https://api.thecatapi.com/v1/favourites?api_key=live_2bP4Aft5O3yEca6knhta8iRtWCky03uCofrQr2f6l5R3j98P7WSS6WSlUxjsmOyh";

            string apiKey = "api_key=live_2bP4Aft5O3yEca6knhta8iRtWCky03uCofrQr2f6l5R3j98P7WSS6WSlUxjsmOyh";

            HttpClient client = new HttpClient { BaseAddress = new Uri(url) };

            var response = await client.GetAsync(url);

            var content = await response.Content.ReadAsStringAsync();

            var FavsCats = JsonConvert.DeserializeObject<List<CatService>>(content);

            return FavsCats;
        }
    }
}
