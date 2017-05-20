namespace FotoStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addarticulos : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Articulos",
                c => new
                    {
                        ArticuloId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 25),
                        Existencia = c.Int(nullable: false),
                        Precio = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.ArticuloId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        VentaId = c.Int(nullable: false, identity: true),
                        Fecha = c.DateTime(nullable: false),
                        TiempoEntrega = c.Int(nullable: false),
                        CantidadItems = c.Int(nullable: false),
                        MontoTotal = c.Double(nullable: false),
                        ClienteId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VentaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Ventas");
            DropTable("dbo.Articulos");
        }
    }
}
