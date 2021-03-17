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
        public bool SaveOrder(int? id, string customerId, int? employeeId, DateTime? orderDate, DateTime? requiredDate, DateTime? shippedDate, int? shipVia, decimal? freight, string shipName, string shipAddress, string shipCity, string shipRegion, string shipPostalCode, string shipCountry)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    Order od = (!id.HasValue) ? new Order() : db.Orders.Where(i => i.OrderID == id).FirstOrDefault();

                    od.CustomerID = customerId;
                    od.EmployeeID = employeeId;
                    od.OrderDate = orderDate;
                    od.RequiredDate = requiredDate;
                    od.ShippedDate = shippedDate;
                    od.ShipVia = shipVia;
                    od.Freight = freight;
                    od.ShipName = shipName;
                    od.ShipAddress = shipAddress;
                    od.ShipCity = shipCity;
                    od.ShipCountry = shipCountry;
                    od.ShipPostalCode = shipPostalCode;
                    od.ShipRegion = shipRegion;
                    if (!id.HasValue)
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

        public List<Orders> GetAllOrder()
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    return db.Orders.Select(i => new Orders
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
                return new List<Orders>();
            }
        }

        public List<Orders> GetOrder(int orderId)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    return db.Orders.Where(i => i.OrderID == orderId).Select(i => new Orders
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
                return new List<Orders>();
            }
        }

        public bool DeleteOrder(int id)
        {
            try
            {
                using (NWDBContext db = new NWDBContext())
                {
                    if (!db.Orders.Any(i => i.OrderID == id))
                        throw new Exception("Student Not Found!");

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
