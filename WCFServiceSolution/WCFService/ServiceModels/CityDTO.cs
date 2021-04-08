using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCFService.ServiceModels
{
    [DataContract]
    public class CityDTO
    {
        [DataMember]
        public int CityId { get; set; }
        [DataMember]
        public string CityName { get; set; }
        [DataMember]
        public int CountryId { get; set; }
    }
}