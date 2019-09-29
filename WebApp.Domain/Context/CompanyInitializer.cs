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
            base.Seed(context);
        }
    }
}
