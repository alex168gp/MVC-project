using System.Collections.Generic;
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
            for (int i = 0; i < 20; i++)
            {
                context.Employees.Add(new Employee
                {
                    Name = "Person "+i,
                    Email = "alalala"+i+"@gmail.com",
                });
            }

            context.SaveChanges();
        }
    }
}
