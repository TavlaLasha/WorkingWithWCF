using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WorkingWithWcfService.ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICatalogManagement" in both code and config file together.
    [ServiceContract]
    public interface ICatalogManagement
    {
        [OperationContract]
        void DoWork();
    }
}
