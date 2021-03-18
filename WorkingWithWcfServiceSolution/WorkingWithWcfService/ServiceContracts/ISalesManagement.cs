using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkingWithWcfService.DataContracts;
using WorkingWithWcfService.EF;

namespace WorkingWithWcfService.ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISalesManagement" in both code and config file together.
    [ServiceContract]
    public interface ISalesManagement
    {
        [OperationContract]
        List<OrderDTO> GetAllOrder();
        [OperationContract]
        OrderDTO GetOrder(int orderId);
        [OperationContract]
        bool AddOrder(OrderDTO ob);
        [OperationContract]
        bool DeleteOrder(int id);
    }
}
