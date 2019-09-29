using System.Data.Entity;

namespace WebApp.Domain
{
    /// <summary>
    /// 
    /// </summary>
    public class CompanyInitializer : CreateDatabaseIfNotExists<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            context.Employees.Add(new Employee
            {
                Name = "him"
                //Email = "aaajkkaa@gmail.com"
                //ProjectCount = 1
            });
            context.SaveChanges();
        }
    }
}
