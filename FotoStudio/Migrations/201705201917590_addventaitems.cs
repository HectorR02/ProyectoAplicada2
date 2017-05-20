namespace FotoStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addventaitems : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VentaItems",
                c => new
                    {
                        ItemId = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(),
                        EsServicio = c.Boolean(nullable: false),
                        Cantidad = c.Int(nullable: false),
                        Precio = c.Double(nullable: false),
                        VentaId = c.Int(nullable: false),
                        ArtServId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ItemId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.VentaItems");
        }
    }
}
