using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Domain;

namespace WebApp.WebUI
{
    public class EmployeeShow
    {
        public string EmployeeName { get; set; }

        public List<string> ProjectNames { get; set; }
    }
}