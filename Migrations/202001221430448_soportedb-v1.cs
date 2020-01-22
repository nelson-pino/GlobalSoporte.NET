namespace GlobalSoporte.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class soportedbv1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.String(nullable: false, maxLength: 128),
                        CustomerName = c.String(),
                        CustomerDirec = c.String(),
                        CustomerRif = c.String(),
                        CustomerType = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Factura",
                c => new
                    {
                        FacturaId = c.String(nullable: false, maxLength: 128),
                        FechaFactura = c.DateTime(nullable: false),
                        CustomerId = c.String(),
                        Subtotal = c.String(),
                        Impuesto = c.String(),
                        TotalFactura = c.String(),
                    })
                .PrimaryKey(t => t.FacturaId);
            
            CreateTable(
                "dbo.Item_Factura",
                c => new
                    {
                        ProductId = c.String(nullable: false, maxLength: 128),
                        Cantidad = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        subtotal_siniva = c.Decimal(nullable: false, precision: 18, scale: 2),
                        impuesto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        totalrow = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Factura_FacturaId = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Factura", t => t.Factura_FacturaId)
                .Index(t => t.Factura_FacturaId);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductId = c.String(nullable: false, maxLength: 128),
                        ProductName = c.String(),
                        ProductPrice = c.String(),
                        ProductCategory = c.String(),
                        ProductEx = c.String(),
                    })
                .PrimaryKey(t => t.ProductId);
            
            CreateTable(
                "dbo.Transport",
                c => new
                    {
                        TransportId = c.String(nullable: false, maxLength: 128),
                        TransportName = c.String(),
                        TransportPhone = c.String(),
                        TransportDirecc = c.String(),
                    })
                .PrimaryKey(t => t.TransportId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Nombre = c.String(),
                        Cargo = c.String(),
                        Departamento = c.String(),
                        MapId = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Vendedor",
                c => new
                    {
                        VendedorId = c.String(nullable: false, maxLength: 128),
                        VendedorName = c.String(),
                        Phone = c.String(),
                        Direccion = c.String(),
                        Ruta = c.String(),
                    })
                .PrimaryKey(t => t.VendedorId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Item_Factura", "Factura_FacturaId", "dbo.Factura");
            DropIndex("dbo.Item_Factura", new[] { "Factura_FacturaId" });
            DropTable("dbo.Vendedor");
            DropTable("dbo.Users");
            DropTable("dbo.Transport");
            DropTable("dbo.Products");
            DropTable("dbo.Item_Factura");
            DropTable("dbo.Factura");
            DropTable("dbo.Customers");
        }
    }
}
