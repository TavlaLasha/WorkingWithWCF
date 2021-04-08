using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class City
    {
        [JsonProperty(PropertyName = "CityId")]
        public int CityId { get; set; }
        [JsonProperty(PropertyName = "CityName")]
        public string CityName { get; set; }
        [JsonProperty(PropertyName = "CountryId")]
        public int CountryId { get; set; }
    }
}
