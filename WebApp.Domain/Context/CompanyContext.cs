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
            Database.SetInitializer(new CompanyInitializer());
        }

        DbSet<Client> Clients { get; set; }


        DbSet<Project> Projects { get; set; }


        DbSet<Employee> Employees { get; set; }


        DbSet<ProjectTeam> ProjectTeams { get; set; }

    }
}
