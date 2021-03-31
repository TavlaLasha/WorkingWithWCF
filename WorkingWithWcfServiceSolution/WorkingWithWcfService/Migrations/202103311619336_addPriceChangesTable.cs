namespace WorkingWithWcfService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addPriceChangesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "PriceManagement.PriceChanges",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductID = c.Int(nullable: false),
                        ChangedDate = c.DateTime(),
                        NewPrice = c.Decimal(storeType: "money"),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("PriceManagement.PriceChanges");
        }
    }
}
