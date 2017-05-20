namespace FotoStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addarticulos1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Articulos", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Servicios", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Servicios", "Precio", c => c.Double(nullable: false));
            AlterColumn("dbo.Articulos", "Precio", c => c.Double(nullable: false));
        }
    }
}
