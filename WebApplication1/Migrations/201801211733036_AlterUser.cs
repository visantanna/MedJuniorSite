namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterUser : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Usuarios", "faculdade", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Usuarios", "faculdade", c => c.Int(nullable: false));
        }
    }
}
