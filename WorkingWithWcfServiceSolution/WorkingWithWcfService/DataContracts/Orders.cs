using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WorkingWithWcfService.DataContracts
{
    [DataContract]
    public class Orders
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string CustomerID { get; set; }
        [DataMember]
        public int? EmployeeID { get; set; }
        [DataMember]
        public DateTime? OrderDate { get; set; }
        [DataMember]
        public DateTime? RequiredDate { get; set; }
        [DataMember]
        public DateTime? ShippedDate { get; set; }
        [DataMember]
        public int? ShipVia { get; set; }
        [DataMember]
        public decimal? Freight { get; set; }
        [DataMember]
        public string ShipName { get; set; }
        [DataMember]
        public string ShipAddress { get; set; }
        [DataMember]
        public string ShipCity { get; set; }
        [DataMember]
        public string ShipRegion { get; set; }
        [DataMember]
        public string ShipPostalCode { get; set; }
        [DataMember]
        public string ShipCountry { get; set; }
    }
}