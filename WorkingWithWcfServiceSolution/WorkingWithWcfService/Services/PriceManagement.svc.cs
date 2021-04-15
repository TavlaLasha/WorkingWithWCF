using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkingWithWcfService.EF;
using System.Data.Entity;

namespace WorkingWithWcfService.ServiceContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PriceManagement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select PriceManagement.svc or PriceManagement.svc.cs at the Solution Explorer and start debugging.
    public class PriceManagement : IPriceManagement
    {
        public bool AddNewProductPrice(int product_id, decimal price)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    PriceChanx pc = new PriceChanx();
                    pc.ProductID = product_id;
                    pc.NewPrice = price;
                    pc.ChangedDate = DateTime.Now;
                    db.PriceChanges.Add(pc);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ee)
            {
                return false;
            }
        }

        public bool ChangeProductPrice(DateTime dt)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    using (DbContextTransaction transaction = db.Database.BeginTransaction())
                    {
                        try
                        {
                            var changes = db.PriceChanges.Where(i => i.ChangedDate.Year == dt.Year && i.ChangedDate.Month == dt.Month && i.ChangedDate.Day == dt.Day);
                            changes.ToList().ForEach(i =>
                            {
                                Product p = db.Products.Where(t => t.ProductID == i.ProductID).First();
                                p.UnitPrice = i.NewPrice;
                            });
                            db.SaveChanges();
                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            throw ex;
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                return false;
            }
        }
    }
}
