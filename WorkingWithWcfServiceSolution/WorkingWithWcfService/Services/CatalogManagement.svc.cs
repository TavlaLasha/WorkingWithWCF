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
        public void AddSupplier(string compname, string contName, string contTitle, string addrss, string ct, string rgn, string pstCode, string cntry, string phn, string fx, string hmPage)
        {
            using (NWDBContext db = new NWDBContext())
            {
                Supplier s = new Supplier();
                s.CompanyName = compname;
                s.ContactName = contName;
                s.ContactTitle = contTitle;
                s.Address = addrss;
                s.City = ct;
                s.Region = rgn;
                s.PostalCode = pstCode;
                s.Country = cntry;
                s.Phone = phn;
                s.Fax = fx;
                s.HomePage = hmPage;
                db.Suppliers.Add(s);
                db.SaveChanges();
            }
        }

        public void DeleteSupplier(int supplierId)
        {
            using (NWDBContext db = new NWDBContext())
            {
                Supplier s = db.Suppliers.Where(i => i.SupplierID.Equals(supplierId)).First();
                db.Suppliers.Remove(s);
                db.SaveChanges();
            }
        }

        public List<Suppliers> GetAllSuppliers()
        {
            using (NWDBContext db = new NWDBContext())
            {
                return db.Suppliers.Select(i => new Suppliers
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

        public Suppliers GetSupplier(int supplierId)
        {
            using (NWDBContext db = new NWDBContext())
            {
                return db.Suppliers.Where(i => i.SupplierID == supplierId).Select(i => new Suppliers
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
    }
}
