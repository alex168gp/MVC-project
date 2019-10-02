namespace WebApp.Domain
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApp.Domain.CompanyContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "WebApp.Domain.CompanyContext";
        }

        protected override void Seed(WebApp.Domain.CompanyContext context)
        {
            //  This method will be called after migrating to the latest version.
            
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
