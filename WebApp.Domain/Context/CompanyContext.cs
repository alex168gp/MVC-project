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
            //Database.CreateIfNotExists();
            Database.SetInitializer<CompanyContext>(new CompanyInitializer());
            Database.Initialize(true);
        }

        //public DbSet<Client> Clients { get; set; }


        //public DbSet<Project> Projects { get; set; }


        public DbSet<Employee> Employees { get; set; }


        //public DbSet<ProjectTeam> ProjectTeams { get; set; }

    }
}
