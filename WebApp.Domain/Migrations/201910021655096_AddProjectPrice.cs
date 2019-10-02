namespace WebApp.Domain
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProjectPrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Projects", "Price");
        }
    }
}
