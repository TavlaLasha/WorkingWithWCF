using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.EF;
using WCFService.ServiceModels;

namespace WCFService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CountryManagement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CountryManagement.svc or CountryManagement.svc.cs at the Solution Explorer and start debugging.
    public class CountryManagement : ICountryManagement
    {
        public Response<List<CountryDTO>> GetAllCountries()
        {
            try
            {
                using (VoiceVoteDB db = new VoiceVoteDB())
                {
                    var result = db.Countries.Select(i =>
                    new CountryDTO
                    {
                        CountryId = i.Country_Id,
                        CountryName = i.Country_Name
                    }).ToList();
                    return new Response<List<CountryDTO>> { Data = result };
                }
            }
            catch (Exception ex)
            {
                return new Response<List<CountryDTO>> { IsError = true, ErrorMessage = ex.Message };
            }
        }
    }
}
