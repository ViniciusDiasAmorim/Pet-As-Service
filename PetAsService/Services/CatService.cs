using Newtonsoft.Json;
using PetAsService.Models;
using System.Text;

namespace PetAsService.Services
{
    public class CatService
    {
        public string image_id { get; set; }
        public string sub_id { get; set; }
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

        //Metodo que retorna os gatos
        public async Task<List<Cat>> GetFavCat()
        {
            string apiKey = "live_2bP4Aft5O3yEca6knhta8iRtWCky03uCofrQr2f6l5R3j98P7WSS6WSlUxjsmOyh";

            string url = $"https://api.thecatapi.com/v1/favourites?api_key={apiKey}";

            HttpClient client = new HttpClient();

            var response = await client.GetAsync(url);

            var content = await response.Content.ReadAsStringAsync();

            List<CatService> favoritesCats = JsonConvert.DeserializeObject<List<CatService>>(content);

            List<Cat> catsForView = new List<Cat>();

            foreach (var item in favoritesCats)
            {
                string urlGetBreed = $"https://api.thecatapi.com/v1/images/{item.image_id}";

                var responseGetBreed = await client.GetAsync(urlGetBreed);

                if (responseGetBreed.IsSuccessStatusCode)
                {
                    var content1 = await responseGetBreed.Content.ReadAsStringAsync();

                    dynamic breed = JsonConvert.DeserializeObject(content1);

                    string name = breed.breeds[0].name;
                    string origin = breed.breeds[0].origin;
                    string temperament = breed.breeds[0].temperament;
                    string description = breed.breeds[0].description;
                    string imageId = breed.breeds[0].reference_image_id;

                    Cat catFav = new Cat()
                    {
                        Id = item.image_id,
                        Name = name,
                        Origin = origin,
                        Temperament = temperament,
                        Description = description,
                        ReferenceImageId = imageId
                    };

                    catsForView.Add(catFav);
                }
            }
            return catsForView;
        }
    }
}
