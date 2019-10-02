namespace WebApp.Domain
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        PhoneNumber = c.String(),
                        CurrentProject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.CurrentProject_Id)
                .Index(t => t.CurrentProject_Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Difficulty = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        ProjectTimeDuration = c.DateTime(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Email = c.String(),
                        ProjectCount = c.Int(nullable: false),
                        Availability = c.Boolean(nullable: false),
                        MaxProjects = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectTeams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MaxCapacity = c.Int(nullable: false),
                        CurrentProject_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.CurrentProject_Id)
                .Index(t => t.CurrentProject_Id);
            
            CreateTable(
                "dbo.ProjectTeamEmployees",
                c => new
                    {
                        ProjectTeam_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.ProjectTeam_Id, t.Employee_Id })
                .ForeignKey("dbo.ProjectTeams", t => t.ProjectTeam_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .Index(t => t.ProjectTeam_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ProjectTeamEmployees", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.ProjectTeamEmployees", "ProjectTeam_Id", "dbo.ProjectTeams");
            DropForeignKey("dbo.ProjectTeams", "CurrentProject_Id", "dbo.Projects");
            DropForeignKey("dbo.Clients", "CurrentProject_Id", "dbo.Projects");
            DropIndex("dbo.ProjectTeamEmployees", new[] { "Employee_Id" });
            DropIndex("dbo.ProjectTeamEmployees", new[] { "ProjectTeam_Id" });
            DropIndex("dbo.ProjectTeams", new[] { "CurrentProject_Id" });
            DropIndex("dbo.Clients", new[] { "CurrentProject_Id" });
            DropTable("dbo.ProjectTeamEmployees");
            DropTable("dbo.ProjectTeams");
            DropTable("dbo.Employees");
            DropTable("dbo.Projects");
            DropTable("dbo.Clients");
        }
    }
}
