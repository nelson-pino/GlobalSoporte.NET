namespace GlobalSoporte.NET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class soportedbv3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Correo", c => c.String());
            AddColumn("dbo.Users", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Users", "Correo");
        }
    }
}
