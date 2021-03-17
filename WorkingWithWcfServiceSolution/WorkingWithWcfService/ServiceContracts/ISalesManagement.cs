using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkingWithWcfService.DataContracts;

namespace WorkingWithWcfService.ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISalesManagement" in both code and config file together.
    [ServiceContract]
    public interface ISalesManagement
    {
        [OperationContract]
        List<Orders> GetAllOrder();
        [OperationContract]
        List<Orders> GetOrder(int orderId);
        [OperationContract]
        bool SaveOrder(int? id, string customerId, int? employeeId, DateTime? orderDate, DateTime? requiredDate, DateTime? shippedDate, int? shipVia, decimal? freight, string shipName, string shipAddress, string shipCity, string shipRegion, string shipPostalCode, string shipCountry);
        [OperationContract]
        bool DeleteOrder(int id);
    }
}
