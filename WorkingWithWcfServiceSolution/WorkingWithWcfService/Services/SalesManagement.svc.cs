using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using WorkingWithWcfService.DataContracts;
using WorkingWithWcfService.EF;
using WorkingWithWcfService.ServiceContracts;

namespace WorkingWithWcfService.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "SalesManagement" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select SalesManagement.svc or SalesManagement.svc.cs at the Solution Explorer and start debugging.
    public class SalesManagement : ISalesManagement
    {
        public bool AddOrder(OrderDTO ob)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    Order od = new Order();

                    od.CustomerID = ob.CustomerID;
                    od.EmployeeID = ob.EmployeeID;
                    od.OrderDate = ob.OrderDate;
                    od.RequiredDate = ob.RequiredDate;
                    od.ShippedDate = ob.ShippedDate;
                    od.ShipVia = ob.ShipVia;
                    od.Freight = ob.Freight;
                    od.ShipName = ob.ShipName;
                    od.ShipAddress = ob.ShipAddress;
                    od.ShipCity = ob.ShipCity;
                    od.ShipCountry = ob.ShipCountry;
                    od.ShipPostalCode = ob.ShipPostalCode;
                    od.ShipRegion = ob.ShipRegion;
                    db.Orders.Add(od);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ee)
            {
                return false;
            }
        }

        public List<OrderDTO> GetAllOrder()
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    return db.Orders.Select(i => new OrderDTO
                    {
                        Id = i.OrderID,
                        CustomerID = i.CustomerID,
                        EmployeeID = i.EmployeeID,
                        OrderDate = i.OrderDate,
                        RequiredDate = i.RequiredDate,
                        ShippedDate = i.ShippedDate,
                        ShipVia = i.ShipVia,
                        Freight = i.Freight,
                        ShipName = i.ShipName,
                        ShipAddress = i.ShipAddress,
                        ShipCity = i.ShipCity,
                        ShipCountry = i.ShipCountry,
                        ShipPostalCode = i.ShipPostalCode,
                        ShipRegion = i.ShipRegion
                    }).ToList();
                }
            }
            catch (Exception)
            {
                return new List<OrderDTO>();
            }
        }

        public OrderDTO GetOrder(int orderId)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    if (!db.Orders.Any(i => i.OrderID == orderId))
                        throw new Exception("Order Not Found");

                    return db.Orders.Where(i => i.OrderID == orderId).Select(i => new OrderDTO
                    {
                        Id = i.OrderID,
                        CustomerID = i.CustomerID,
                        EmployeeID = i.EmployeeID,
                        OrderDate = i.OrderDate,
                        RequiredDate = i.RequiredDate,
                        ShippedDate = i.ShippedDate,
                        ShipVia = i.ShipVia,
                        Freight = i.Freight,
                        ShipName = i.ShipName,
                        ShipAddress = i.ShipAddress,
                        ShipCity = i.ShipCity,
                        ShipCountry = i.ShipCountry,
                        ShipPostalCode = i.ShipPostalCode,
                        ShipRegion = i.ShipRegion
                    }).First();
                }
            }
            catch (Exception)
            {
                return new OrderDTO();
            }
        }

        public bool DeleteOrder(int id)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    if (!db.Orders.Any(i => i.OrderID == id))
                        throw new Exception("Order Not Found!");

                    Order od =  db.Orders.Where(i => i.OrderID == id).First();
                    db.Orders.Remove(od);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
