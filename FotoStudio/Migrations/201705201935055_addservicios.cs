namespace FotoStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addservicios : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Servicios", "Precio", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Servicios", "Precio", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
    }
}
