using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApp.Domain;

namespace WebApp.WebUI
{
    public class ProjectsShow
    {
        /// <summary>
        /// A list of company projects
        /// </summary>
        public IEnumerable<Project> Projects { get; set; }

        /// <summary>
        /// Information about page
        /// </summary>
        public PageInfo PageInfo { get; set; }
    }
}