using Newtonsoft.Json;
using PetAsService.Models;
using System.Text;

namespace PetAsService.Services
{
    public class CatService
    {
        //Metodo que retorna um gato
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

        //Metodo que favorita os gatos
        public async Task<string> FavCat(Cat cat)
        {
            HttpClient client = new HttpClient();

            string apiKey = "live_2bP4Aft5O3yEca6knhta8iRtWCky03uCofrQr2f6l5R3j98P7WSS6WSlUxjsmOyh";

            client.DefaultRequestHeaders.Add("x-api-key", apiKey);

            var catPost = new FavoriteCat()
            {
                ImageId = $"{cat.ReferenceImageId}",
                SubId = $"teste1"
            };

            var catJson = JsonConvert.SerializeObject(catPost);

            var data = new StringContent(catJson, Encoding.UTF8, "application/json");

            var url = $"https://api.thecatapi.com/v1/favourites?";

            var response = await client.PostAsync(url, data);

            string result = response.Content.ReadAsStringAsync().Result;

            if (response.IsSuccessStatusCode)
            {
                return  $"{cat.Name} favoritado com sucesso !!";
            }

            return $"Ocorreu um problema em favoritar o {cat.Name} talvez voce ja tenha favoritado ele.";
        }

        //Metodo que retorna os gatos favoritos
        public async Task<List<FavoriteCat>> GetFavCat()
        {
            string apiKey = "live_2bP4Aft5O3yEca6knhta8iRtWCky03uCofrQr2f6l5R3j98P7WSS6WSlUxjsmOyh";

            string url = $"https://api.thecatapi.com/v1/favourites?";

            HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Add("x-api-key", apiKey);

            var response = await client.GetAsync(url);

            var content = await response.Content.ReadAsStringAsync();

            List<FavoriteCat> favoritesCats = JsonConvert.DeserializeObject<List<FavoriteCat>>(content);

            foreach (var item in favoritesCats)
            {
                string urlGetBreed = $"https://api.thecatapi.com/v1/images/{item.ImageId}";

                var responseGetBreed = await client.GetAsync(urlGetBreed);

                if (responseGetBreed.IsSuccessStatusCode)
                {
                    var contentGetBreed = await responseGetBreed.Content.ReadAsStringAsync();

                    dynamic breed = JsonConvert.DeserializeObject(contentGetBreed);

                    string name = breed.breeds[0].name;

                    item.Name = name;
                }
            }
            return favoritesCats;
        }
        //Metodo que Deleta um gato favorito
        public async Task<bool> DeleteFavCat(int id)
        {
            HttpClient client = new HttpClient();

            string apiKey = "live_2bP4Aft5O3yEca6knhta8iRtWCky03uCofrQr2f6l5R3j98P7WSS6WSlUxjsmOyh";

            client.DefaultRequestHeaders.Add("x-api-key", apiKey);

            string urlDelete = $"https://api.thecatapi.com/v1/favourites/{id}";

            var responseDelete = await client.DeleteAsync(urlDelete);
            
            if(responseDelete.IsSuccessStatusCode)
            {
                return true;
            }

            return false;
        }
    }
}
