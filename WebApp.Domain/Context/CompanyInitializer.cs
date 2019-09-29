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
            var emp = new Employee
            {
                Name = "him"
                //Email = "aaajkkaa@gmail.com"
                //ProjectCount = 1
            };

            context.Employees.Add(emp);
            context.SaveChanges();
        }
    }
}
