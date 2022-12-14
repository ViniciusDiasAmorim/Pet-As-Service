using Newtonsoft.Json;

namespace PetAsService.Models
{
    public class Cat
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Temperament { get; set; }
        public string Origin { get; set; }
        public string Description { get; set; }

        [JsonProperty("reference_image_id")]
        public string ReferenceImageId { get; set; }
    }
}
