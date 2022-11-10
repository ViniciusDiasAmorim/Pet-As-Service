using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetAsService.Models
{
    public class FavoriteCat
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonIgnore]
        public string Name { get; set; }

        [JsonProperty("image_id")]
        public string ImageId { get; set; }
        [JsonProperty("sub_id")]
        public string SubId { get; set; }
    }
}
