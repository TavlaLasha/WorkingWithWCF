using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkingWithWcfService.EF;

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
                    PriceChanges pc = new PriceChanges();
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
    }
}
