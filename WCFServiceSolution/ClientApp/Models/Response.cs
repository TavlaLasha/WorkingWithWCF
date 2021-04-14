using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ClientApp.Models;

namespace WCFService.ServiceModels
{
    public class Response <T>
    {
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
        public List<T> Data { get; set; }
    }
}