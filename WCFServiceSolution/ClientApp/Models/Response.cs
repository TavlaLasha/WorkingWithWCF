using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.ServiceModels
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class Response <T>
    {
        [JsonProperty(PropertyName = "IsError")]
        public bool IsError { get; set; }
        [JsonProperty(PropertyName = "ErrorMessage")]
        public string ErrorMessage { get; set; }
        [JsonProperty(PropertyName = "Data")]
        public T Data { get; set; }
    }
}