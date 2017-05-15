namespace FotoStudio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class serviciosvalidacion : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Servicios", "Descripcion", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Servicios", "Descripcion", c => c.String());
        }
    }
}
