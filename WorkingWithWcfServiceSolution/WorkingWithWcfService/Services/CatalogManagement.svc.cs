using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkingWithWcfService.DataContracts;
using WorkingWithWcfService.ServiceContracts;
using WorkingWithWcfService.EF;

namespace WorkingWithWcfService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CatalogManagement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select CatalogManagement.svc or CatalogManagement.svc.cs at the Solution Explorer and start debugging.
    public class CatalogManagement : ICatalogManagement
    {
        public bool AddSupplier(SupplierDTO ob)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    Supplier s = new Supplier();
                    s.CompanyName = ob.CompName;
                    s.ContactName = ob.ContName;
                    s.ContactTitle = ob.ContTitle;
                    s.Address = ob.Addrss;
                    s.City = ob.Ct;
                    s.Region = ob.Rgn;
                    s.PostalCode = ob.PstCode;
                    s.Country = ob.Cntry;
                    s.Phone = ob.Phn;
                    s.Fax = ob.Fx;
                    s.HomePage = ob.HmPage;
                    db.Suppliers.Add(s);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception )
            {
                return false;
            }
        }

        public bool DeleteSupplier(int supplierId)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    if (!db.Suppliers.Any(i => i.SupplierID == supplierId))
                        throw new Exception("Order Not Found!");

                    Supplier od = db.Suppliers.Where(i => i.SupplierID == supplierId).First();
                    db.Suppliers.Remove(od);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<SupplierDTO> GetAllSuppliers()
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    return db.Suppliers.Select(i => new SupplierDTO
                    {
                        Id = i.SupplierID,
                        CompName = i.CompanyName,
                        ContName = i.ContactName,
                        ContTitle = i.ContactTitle,
                        Addrss = i.Address,
                        Ct = i.City,
                        Rgn = i.Region,
                        PstCode = i.PostalCode,
                        Cntry = i.Country,
                        Phn = i.Phone,
                        Fx = i.Fax,
                        HmPage = i.HomePage
                    }).ToList();
                }
            }
            catch (Exception)
            {

                return new List<SupplierDTO>();
            }
        }

        public SupplierDTO GetSupplier(int supplierId)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    return db.Suppliers.Where(i => i.SupplierID == supplierId).Select(i => new SupplierDTO
                    {
                        Id = i.SupplierID,
                        CompName = i.CompanyName,
                        ContName = i.ContactName,
                        ContTitle = i.ContactTitle,
                        Addrss = i.Address,
                        Ct = i.City,
                        Rgn = i.Region,
                        PstCode = i.PostalCode,
                        Cntry = i.Country,
                        Phn = i.Phone,
                        Fx = i.Fax,
                        HmPage = i.HomePage
                    }).FirstOrDefault();
                }
            }
            catch (Exception)
            {

                return new SupplierDTO();
            }
        }
    }
}
