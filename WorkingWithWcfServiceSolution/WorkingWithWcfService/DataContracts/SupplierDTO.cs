﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace WorkingWithWcfService.DataContracts
{
    [DataContract]
    public class SupplierDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CompName { get; set; }
        [DataMember]
        public string ContName { get; set; }
        [DataMember]
        public string ContTitle { get; set; }
        [DataMember]
        public string Addrss { get; set; }
        [DataMember]
        public string Ct { get; set; }
        [DataMember]
        public string Rgn { get; set; }
        [DataMember]
        public string PstCode { get; set; }
        [DataMember]
        public string Cntry { get; set; }
        [DataMember]
        public string Phn { get; set; }
        [DataMember]
        public string Fx { get; set; }
        [DataMember]
        public string HmPage { get; set; }

    }
}