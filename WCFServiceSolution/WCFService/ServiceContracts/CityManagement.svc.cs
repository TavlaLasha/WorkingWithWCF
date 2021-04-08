using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WCFService.EF;
using WCFService.ServiceModels;

namespace WCFService.ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CityManagement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CityManagement.svc or CityManagement.svc.cs at the Solution Explorer and start debugging.
    public class CityManagement : ICityManagement
    {
        public Response<bool> AddCity(CityDTO ct)
        {
            try
            {
                using (VoiceVoteDB db = new VoiceVoteDB())
                {
                    City cty = new City();
                    cty.City_Name = ct.CityName;
                    cty.Country_Id = ct.CountryId;
                    db.Cities.Add(cty);
                    db.SaveChanges();
                }
                return new Response<bool> { Data = true };
            }
            catch (Exception ex)
            {
                return new Response<bool> { IsError = true, ErrorMessage = ex.Message };
            }
        }

        public Response<bool> DeleteCity(string cityId)
        {
            try
            {
                int Id;
                if (!int.TryParse(cityId, out Id))
                    throw new Exception($"Invalid city Id: {cityId} !");
                using (VoiceVoteDB db = new VoiceVoteDB())
                {
                    if (!db.Cities.Any(i => i.City_Id == Id))
                        throw new Exception($"City with Id: {cityId} not found!");
                    City cty = db.Cities.Where(i => i.City_Id == Id).Single();
                    db.Cities.Remove(cty);
                    db.SaveChanges();
                }
                return new Response<bool> { Data = true };
            }
            catch (Exception ex)
            {
                return new Response<bool> { IsError = true, ErrorMessage = ex.Message };
            }
        }

        public Response<List<CityDTO>> GetAllCities()
        {
            try
            {
                using (VoiceVoteDB db = new VoiceVoteDB())
                {
                    var result = db.Cities.Select(i =>
                    new CityDTO
                    {
                        CityId = i.City_Id,
                        CityName = i.City_Name,
                        CountryId = i.Country_Id.HasValue ? i.Country_Id.Value : 0
                    }).ToList();
                    return new Response<List<CityDTO>> { Data = result};
                }
            }
            catch (Exception ex)
            {
                return new Response<List<CityDTO>> { IsError = true, ErrorMessage = ex.Message };
            }
        }

        public Response<bool> UpdateCity(CityDTO ct)
        {
            try
            {
                using (VoiceVoteDB db = new VoiceVoteDB())
                {
                    if (!db.Cities.Any(i => i.City_Id == ct.CityId))
                        throw new Exception($"City with Id: {ct.CityId} not found!");
                    City cty = db.Cities.Where(i => i.City_Id == ct.CityId).Single();
                    cty.City_Name = ct.CityName;
                    cty.Country_Id = ct.CountryId;
                    db.SaveChanges();
                }
                return new Response<bool> { Data = true };
            }
            catch (Exception ex)
            {
                return new Response<bool> { IsError = true, ErrorMessage = ex.Message };
            }
        }
    }
}
