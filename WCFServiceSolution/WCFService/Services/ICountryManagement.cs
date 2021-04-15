using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFService.ServiceModels;

namespace WCFService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICountryManagement" in both code and config file together.
    [ServiceContract]
    public interface ICountryManagement
    {
        [OperationContract]
        [WebGet(UriTemplate = "/GetAllCountries", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Response<List<CountryDTO>> GetAllCountries();
    }
}
