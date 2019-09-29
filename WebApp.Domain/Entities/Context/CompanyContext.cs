using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApp.Domain.Context
{
    public class CompanyContext: DbContext
    {
        public CompanyContext(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public IDbSet<Employee> Employees { get; set; }
    }
}