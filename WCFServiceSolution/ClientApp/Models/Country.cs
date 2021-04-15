using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp.Models
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Country
    {
        [JsonProperty(PropertyName = "CountryId")]
        public int CountryId { get; set; }
        [JsonProperty(PropertyName = "CountryName")]
        public string CountryName { get; set; }
    }
}
