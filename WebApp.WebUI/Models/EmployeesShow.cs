using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Domain;

namespace WebApp.WebUI
{
    public class EmployeesShow
    {
        /// <summary>
        /// A list of company employees and project they're working for
        /// </summary>
        public IEnumerable<EmployeeShow> EmployeesWork { get; set; }

    }
}