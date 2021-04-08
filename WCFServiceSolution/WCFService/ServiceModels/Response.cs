using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCFService.ServiceModels
{
    public class Response <T>
    {
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}