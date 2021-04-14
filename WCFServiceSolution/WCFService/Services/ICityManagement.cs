﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WCFService.ServiceModels;

namespace WCFService.ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICityManagement" in both code and config file together.
    [ServiceContract]
    public interface ICityManagement
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/AddNewCity", Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Response<bool> AddCity(CityDTO ct);

        [OperationContract]
        [WebInvoke(UriTemplate = "/UpdateCity", Method = "PUT", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Response<bool> UpdateCity(CityDTO ct);

        [OperationContract]
        [WebInvoke(UriTemplate = "/DeleteCity/{cityId}", Method = "DELETE", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Response<bool> DeleteCity(string cityId);

        [OperationContract]
        [WebGet(UriTemplate = "/GetAllCities", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Response<List<CityDTO>> GetAllCities();

        [OperationContract]
        [WebGet(UriTemplate = "/GetCity/{cityId}", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Response<CityDTO> GetCity(string cityId);
    }
}
