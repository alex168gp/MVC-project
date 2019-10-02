using System.Data.Entity;

namespace WebApp.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class CompanyContext : DbContext
    {
        public CompanyContext() : base("DefaultConnection")
        {
            // set an initializer for initial database fill    new CompanyInitializer()
            Database.SetInitializer<CompanyContext>(null);

            // force creation
            Database.Initialize(true);
        }

        public DbSet<Client> Clients { get; set; }


        public DbSet<Project> Projects { get; set; }


        public DbSet<Employee> Employees { get; set; }


        public DbSet<ProjectTeam> ProjectTeams { get; set; }

    }
}
