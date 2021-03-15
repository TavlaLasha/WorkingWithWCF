using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkingWithWcfService.DataContracts;

namespace WorkingWithWcfService.ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICatalogManagement" in both code and config file together.
    [ServiceContract]
    public interface ICatalogManagement
    {
        [OperationContract]
        Suppliers GetSupplier(int supplierId);

        [OperationContract]
        List<Suppliers> GetAllSuppliers();
        [OperationContract]
        void AddSupplier(string compname, string contName, string contTitle, string addrss, string ct, string rgn, string pstCode, string cntry, string phn, string fx, string hmPage);
        [OperationContract]
        void DeleteSupplier(int supplierId);

    }
}
