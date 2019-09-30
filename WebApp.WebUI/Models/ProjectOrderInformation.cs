using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Domain;

namespace WebApp.WebUI
{
    public class ProjectOrderInformation
    {
        /// <summary>
        /// When team started to work on a project
        /// </summary>
        public DateTime StartDate { get; set; } = DateTime.UtcNow.AddDays(7);

        /// <summary>
        /// Estimated time that need team to complete project
        /// </summary>
        public DateTime ProjectTimeDuration { get; set; } = DateTime.UtcNow.AddDays(37);

        public List<Employee> Employees { get; set; }
    }
}