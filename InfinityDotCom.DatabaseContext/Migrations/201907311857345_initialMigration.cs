namespace InfinityDotCom.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CategoryCode = c.String(),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CustomerCode = c.String(),
                        CustomerName = c.String(),
                        CustomerAddress = c.String(),
                        CustomerEmail = c.String(),
                        CustomerContact = c.String(),
                        CustomerLP = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(),
                        ProductName = c.String(),
                        ProductROL = c.Int(nullable: false),
                        ProductDescription = c.String(),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        SupplierCode = c.String(),
                        SupplierName = c.String(),
                        SupplierAddress = c.String(),
                        SupplierEmail = c.String(),
                        SupplierContact = c.String(),
                        SupplierContactPerson = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.Suppliers");
            DropTable("dbo.Products");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
