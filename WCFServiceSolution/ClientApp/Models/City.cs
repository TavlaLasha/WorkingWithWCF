using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClientApp.Models
{
    //[JsonObject(MemberSerialization = MemberSerialization.OptIn)]

    //[XmlRoot("Wrapper")]
    //public class Wrapper
    //{
    //    [XmlAttribute("Data")]
    //    public City Data { get; set; }
    //}
    //[Serializable,XmlRoot("data")]
    [XmlRoot]
    public class City
    {
        //[JsonProperty(PropertyName = "CityId")]
        [XmlElement]
        public int CityId { get; set; }
        //[JsonProperty(PropertyName = "CityName")]
        [XmlElement]
        public string CityName { get; set; }
        //[JsonProperty(PropertyName = "CountryId")]
        [XmlElement]
        public int CountryId { get; set; }
    }
}
