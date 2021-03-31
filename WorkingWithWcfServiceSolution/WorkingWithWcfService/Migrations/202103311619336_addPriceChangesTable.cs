namespace WorkingWithWcfService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPriceChangesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Alphabetical list of products",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        Discontinued = c.Boolean(nullable: false),
                        CategoryName = c.String(nullable: false, maxLength: 15),
                        SupplierID = c.Int(),
                        CategoryID = c.Int(),
                        QuantityPerUnit = c.String(maxLength: 20),
                        UnitPrice = c.Decimal(storeType: "money"),
                        UnitsInStock = c.Short(),
                        UnitsOnOrder = c.Short(),
                        ReorderLevel = c.Short(),
                    })
                .PrimaryKey(t => new { t.ProductID, t.ProductName, t.Discontinued, t.CategoryName });
            
            CreateTable(
                "Catalogs.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false, maxLength: 15),
                        Description = c.String(storeType: "ntext"),
                        Picture = c.Binary(storeType: "image"),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "Catalogs.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        SupplierID = c.Int(),
                        CategoryID = c.Int(),
                        QuantityPerUnit = c.String(maxLength: 20),
                        UnitPrice = c.Decimal(storeType: "money"),
                        UnitsInStock = c.Short(),
                        UnitsOnOrder = c.Short(),
                        ReorderLevel = c.Short(),
                        Discontinued = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("Catalogs.Categories", t => t.CategoryID)
                .ForeignKey("Catalogs.Suppliers", t => t.SupplierID)
                .Index(t => t.SupplierID)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "Sales.Order Details",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, storeType: "money"),
                        Quantity = c.Short(nullable: false),
                        Discount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("Sales.Orders", t => t.OrderID)
                .ForeignKey("Catalogs.Products", t => t.ProductID)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "Sales.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        CustomerID = c.String(maxLength: 5, fixedLength: true),
                        EmployeeID = c.Int(),
                        OrderDate = c.DateTime(),
                        RequiredDate = c.DateTime(),
                        ShippedDate = c.DateTime(),
                        ShipVia = c.Int(),
                        Freight = c.Decimal(storeType: "money"),
                        ShipName = c.String(maxLength: 40),
                        ShipAddress = c.String(maxLength: 60),
                        ShipCity = c.String(maxLength: 15),
                        ShipRegion = c.String(maxLength: 15),
                        ShipPostalCode = c.String(maxLength: 10),
                        ShipCountry = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("Customers.Customers", t => t.CustomerID)
                .ForeignKey("Employees.Employees", t => t.EmployeeID)
                .ForeignKey("Catalogs.Shippers", t => t.ShipVia)
                .Index(t => t.CustomerID)
                .Index(t => t.EmployeeID)
                .Index(t => t.ShipVia);
            
            CreateTable(
                "Customers.Customers",
                c => new
                    {
                        CustomerID = c.String(nullable: false, maxLength: 5, fixedLength: true),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        ContactName = c.String(maxLength: 30),
                        ContactTitle = c.String(maxLength: 30),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Region = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                        Phone = c.String(maxLength: 24),
                        Fax = c.String(maxLength: 24),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "Customers.CustomerDemographics",
                c => new
                    {
                        CustomerTypeID = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        CustomerDesc = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.CustomerTypeID);
            
            CreateTable(
                "Employees.Employees",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false, identity: true),
                        LastName = c.String(nullable: false, maxLength: 20),
                        FirstName = c.String(nullable: false, maxLength: 10),
                        CountryID = c.Int(nullable: false),
                        CityID = c.Int(nullable: false),
                        Title = c.String(maxLength: 30),
                        TitleOfCourtesy = c.String(maxLength: 25),
                        BirthDate = c.DateTime(),
                        HireDate = c.DateTime(),
                        Address = c.String(maxLength: 60),
                        Region = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        HomePhone = c.String(maxLength: 24),
                        Extension = c.String(maxLength: 4),
                        Photo = c.Binary(storeType: "image"),
                        Notes = c.String(storeType: "ntext"),
                        ReportsTo = c.Int(),
                        PhotoPath = c.String(maxLength: 255),
                    })
                .PrimaryKey(t => t.EmployeeID)
                .ForeignKey("Catalogs.Countries", t => t.CountryID)
                .ForeignKey("Catalogs.Cities", t => t.CityID)
                .ForeignKey("Employees.Employees", t => t.ReportsTo)
                .Index(t => t.CountryID)
                .Index(t => t.CityID)
                .Index(t => t.ReportsTo);
            
            CreateTable(
                "Catalogs.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        CountryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("Catalogs.Countries", t => t.CountryID)
                .Index(t => t.CountryID);
            
            CreateTable(
                "Catalogs.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "Catalogs.Territories",
                c => new
                    {
                        TerritoryID = c.String(nullable: false, maxLength: 20),
                        TerritoryDescription = c.String(nullable: false, maxLength: 50, fixedLength: true),
                        RegionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TerritoryID)
                .ForeignKey("Catalogs.Region", t => t.RegionID)
                .Index(t => t.RegionID);
            
            CreateTable(
                "Catalogs.Region",
                c => new
                    {
                        RegionID = c.Int(nullable: false),
                        RegionDescription = c.String(nullable: false, maxLength: 50, fixedLength: true),
                    })
                .PrimaryKey(t => t.RegionID);
            
            CreateTable(
                "Catalogs.Shippers",
                c => new
                    {
                        ShipperID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        Phone = c.String(maxLength: 24),
                    })
                .PrimaryKey(t => t.ShipperID);
            
            CreateTable(
                "Catalogs.Suppliers",
                c => new
                    {
                        SupplierID = c.Int(nullable: false, identity: true),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        ContactName = c.String(maxLength: 30),
                        ContactTitle = c.String(maxLength: 30),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Region = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                        Phone = c.String(maxLength: 24),
                        Fax = c.String(maxLength: 24),
                        HomePage = c.String(storeType: "ntext"),
                    })
                .PrimaryKey(t => t.SupplierID);
            
            CreateTable(
                "dbo.Category Sales for 1997",
                c => new
                    {
                        CategoryName = c.String(nullable: false, maxLength: 15),
                        CategorySales = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.CategoryName);
            
            CreateTable(
                "dbo.Current Product List",
                c => new
                    {
                        ProductID = c.Int(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 40),
                    })
                .PrimaryKey(t => new { t.ProductID, t.ProductName });
            
            CreateTable(
                "dbo.Customer and Suppliers by City",
                c => new
                    {
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        Relationship = c.String(nullable: false, maxLength: 9, unicode: false),
                        City = c.String(maxLength: 15),
                        ContactName = c.String(maxLength: 30),
                    })
                .PrimaryKey(t => new { t.CompanyName, t.Relationship });
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        CustomerName = c.String(nullable: false, maxLength: 40),
                        Salesperson = c.String(nullable: false, maxLength: 31),
                        OrderID = c.Int(nullable: false),
                        ShipperName = c.String(nullable: false, maxLength: 40),
                        ProductID = c.Int(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        UnitPrice = c.Decimal(nullable: false, storeType: "money"),
                        Quantity = c.Short(nullable: false),
                        Discount = c.Single(nullable: false),
                        ShipName = c.String(maxLength: 40),
                        ShipAddress = c.String(maxLength: 60),
                        ShipCity = c.String(maxLength: 15),
                        ShipRegion = c.String(maxLength: 15),
                        ShipPostalCode = c.String(maxLength: 10),
                        ShipCountry = c.String(maxLength: 15),
                        CustomerID = c.String(maxLength: 5, fixedLength: true),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Region = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                        OrderDate = c.DateTime(),
                        RequiredDate = c.DateTime(),
                        ShippedDate = c.DateTime(),
                        ExtendedPrice = c.Decimal(storeType: "money"),
                        Freight = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => new { t.CustomerName, t.Salesperson, t.OrderID, t.ShipperName, t.ProductID, t.ProductName, t.UnitPrice, t.Quantity, t.Discount });
            
            CreateTable(
                "dbo.Order Details Extended",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        UnitPrice = c.Decimal(nullable: false, storeType: "money"),
                        Quantity = c.Short(nullable: false),
                        Discount = c.Single(nullable: false),
                        ExtendedPrice = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID, t.ProductName, t.UnitPrice, t.Quantity, t.Discount });
            
            CreateTable(
                "dbo.Order Subtotals",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        Subtotal = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Orders Qry",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        CustomerID = c.String(maxLength: 5, fixedLength: true),
                        EmployeeID = c.Int(),
                        OrderDate = c.DateTime(),
                        RequiredDate = c.DateTime(),
                        ShippedDate = c.DateTime(),
                        ShipVia = c.Int(),
                        Freight = c.Decimal(storeType: "money"),
                        ShipName = c.String(maxLength: 40),
                        ShipAddress = c.String(maxLength: 60),
                        ShipCity = c.String(maxLength: 15),
                        ShipRegion = c.String(maxLength: 15),
                        ShipPostalCode = c.String(maxLength: 10),
                        ShipCountry = c.String(maxLength: 15),
                        Address = c.String(maxLength: 60),
                        City = c.String(maxLength: 15),
                        Region = c.String(maxLength: 15),
                        PostalCode = c.String(maxLength: 10),
                        Country = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => new { t.OrderID, t.CompanyName });
            
            CreateTable(
                "PriceManagement.PriceChanges",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        ChangedDate = c.DateTime(),
                        NewPrice = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.ProductID);
            
            CreateTable(
                "dbo.Product Sales for 1997",
                c => new
                    {
                        CategoryName = c.String(nullable: false, maxLength: 15),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        ProductSales = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => new { t.CategoryName, t.ProductName });
            
            CreateTable(
                "dbo.Products Above Average Price",
                c => new
                    {
                        ProductName = c.String(nullable: false, maxLength: 40),
                        UnitPrice = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.ProductName);
            
            CreateTable(
                "dbo.Products by Category",
                c => new
                    {
                        CategoryName = c.String(nullable: false, maxLength: 15),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        Discontinued = c.Boolean(nullable: false),
                        QuantityPerUnit = c.String(maxLength: 20),
                        UnitsInStock = c.Short(),
                    })
                .PrimaryKey(t => new { t.CategoryName, t.ProductName, t.Discontinued });
            
            CreateTable(
                "dbo.Sales by Category",
                c => new
                    {
                        CategoryID = c.Int(nullable: false),
                        CategoryName = c.String(nullable: false, maxLength: 15),
                        ProductName = c.String(nullable: false, maxLength: 40),
                        ProductSales = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => new { t.CategoryID, t.CategoryName, t.ProductName });
            
            CreateTable(
                "dbo.Sales Totals by Amount",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        CompanyName = c.String(nullable: false, maxLength: 40),
                        SaleAmount = c.Decimal(storeType: "money"),
                        ShippedDate = c.DateTime(),
                    })
                .PrimaryKey(t => new { t.OrderID, t.CompanyName });
            
            CreateTable(
                "dbo.Summary of Sales by Quarter",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ShippedDate = c.DateTime(),
                        Subtotal = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.Summary of Sales by Year",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ShippedDate = c.DateTime(),
                        Subtotal = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "Customers.CustomerCustomerDemo",
                c => new
                    {
                        CustomerTypeID = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        CustomerID = c.String(nullable: false, maxLength: 5, fixedLength: true),
                    })
                .PrimaryKey(t => new { t.CustomerTypeID, t.CustomerID })
                .ForeignKey("Customers.CustomerDemographics", t => t.CustomerTypeID, cascadeDelete: true)
                .ForeignKey("Customers.Customers", t => t.CustomerID, cascadeDelete: true)
                .Index(t => t.CustomerTypeID)
                .Index(t => t.CustomerID);
            
            CreateTable(
                "Employees.EmployeeTerritories",
                c => new
                    {
                        EmployeeID = c.Int(nullable: false),
                        TerritoryID = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => new { t.EmployeeID, t.TerritoryID })
                .ForeignKey("Employees.Employees", t => t.EmployeeID, cascadeDelete: true)
                .ForeignKey("Catalogs.Territories", t => t.TerritoryID, cascadeDelete: true)
                .Index(t => t.EmployeeID)
                .Index(t => t.TerritoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("Catalogs.Products", "SupplierID", "Catalogs.Suppliers");
            DropForeignKey("Sales.Order Details", "ProductID", "Catalogs.Products");
            DropForeignKey("Sales.Orders", "ShipVia", "Catalogs.Shippers");
            DropForeignKey("Sales.Order Details", "OrderID", "Sales.Orders");
            DropForeignKey("Employees.EmployeeTerritories", "TerritoryID", "Catalogs.Territories");
            DropForeignKey("Employees.EmployeeTerritories", "EmployeeID", "Employees.Employees");
            DropForeignKey("Catalogs.Territories", "RegionID", "Catalogs.Region");
            DropForeignKey("Sales.Orders", "EmployeeID", "Employees.Employees");
            DropForeignKey("Employees.Employees", "ReportsTo", "Employees.Employees");
            DropForeignKey("Employees.Employees", "CityID", "Catalogs.Cities");
            DropForeignKey("Employees.Employees", "CountryID", "Catalogs.Countries");
            DropForeignKey("Catalogs.Cities", "CountryID", "Catalogs.Countries");
            DropForeignKey("Sales.Orders", "CustomerID", "Customers.Customers");
            DropForeignKey("Customers.CustomerCustomerDemo", "CustomerID", "Customers.Customers");
            DropForeignKey("Customers.CustomerCustomerDemo", "CustomerTypeID", "Customers.CustomerDemographics");
            DropForeignKey("Catalogs.Products", "CategoryID", "Catalogs.Categories");
            DropIndex("Employees.EmployeeTerritories", new[] { "TerritoryID" });
            DropIndex("Employees.EmployeeTerritories", new[] { "EmployeeID" });
            DropIndex("Customers.CustomerCustomerDemo", new[] { "CustomerID" });
            DropIndex("Customers.CustomerCustomerDemo", new[] { "CustomerTypeID" });
            DropIndex("Catalogs.Territories", new[] { "RegionID" });
            DropIndex("Catalogs.Cities", new[] { "CountryID" });
            DropIndex("Employees.Employees", new[] { "ReportsTo" });
            DropIndex("Employees.Employees", new[] { "CityID" });
            DropIndex("Employees.Employees", new[] { "CountryID" });
            DropIndex("Sales.Orders", new[] { "ShipVia" });
            DropIndex("Sales.Orders", new[] { "EmployeeID" });
            DropIndex("Sales.Orders", new[] { "CustomerID" });
            DropIndex("Sales.Order Details", new[] { "ProductID" });
            DropIndex("Sales.Order Details", new[] { "OrderID" });
            DropIndex("Catalogs.Products", new[] { "CategoryID" });
            DropIndex("Catalogs.Products", new[] { "SupplierID" });
            DropTable("Employees.EmployeeTerritories");
            DropTable("Customers.CustomerCustomerDemo");
            DropTable("dbo.Summary of Sales by Year");
            DropTable("dbo.Summary of Sales by Quarter");
            DropTable("dbo.Sales Totals by Amount");
            DropTable("dbo.Sales by Category");
            DropTable("dbo.Products by Category");
            DropTable("dbo.Products Above Average Price");
            DropTable("dbo.Product Sales for 1997");
            DropTable("PriceManagement.PriceChanges");
            DropTable("dbo.Orders Qry");
            DropTable("dbo.Order Subtotals");
            DropTable("dbo.Order Details Extended");
            DropTable("dbo.Invoices");
            DropTable("dbo.Customer and Suppliers by City");
            DropTable("dbo.Current Product List");
            DropTable("dbo.Category Sales for 1997");
            DropTable("Catalogs.Suppliers");
            DropTable("Catalogs.Shippers");
            DropTable("Catalogs.Region");
            DropTable("Catalogs.Territories");
            DropTable("Catalogs.Countries");
            DropTable("Catalogs.Cities");
            DropTable("Employees.Employees");
            DropTable("Customers.CustomerDemographics");
            DropTable("Customers.Customers");
            DropTable("Sales.Orders");
            DropTable("Sales.Order Details");
            DropTable("Catalogs.Products");
            DropTable("Catalogs.Categories");
            DropTable("dbo.Alphabetical list of products");
        }
    }
}
