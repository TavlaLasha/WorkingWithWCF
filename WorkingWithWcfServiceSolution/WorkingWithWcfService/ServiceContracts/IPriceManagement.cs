using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WorkingWithWcfService.ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IPriceManagement" in both code and config file together.
    [ServiceContract]
    public interface IPriceManagement
    {
        [OperationContract]
        [WebInvoke]
        bool AddNewProductPrice(int product_id, decimal price);
        [OperationContract]
        bool ChangeProductPrice(DateTime dt);
    }
}
