using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp.WebUI
{
    public class ProjectOrder
    {
        public string ClientName { get; set; }

        public string ClientEmail { get; set; }

        public string ClientPhone { get; set; }

        public string ProjectName { get; set; }

        public IEnumerable<SelectListItem> ProjectDifficulties { get; set; }/* = new List<SelectListItem>
        {
            new SelectListItem { Text = "1", Value="1" },
            new SelectListItem { Text = "2", Value="2" },
            new SelectListItem { Text = "3", Value="3" },
            new SelectListItem { Text = "4", Value="4" },
            new SelectListItem { Text = "5", Value="5" }
        };
        */
        public int ProjectDifficulty { get; set; }

        public string ProjectDescription { get; set; }
    }
}