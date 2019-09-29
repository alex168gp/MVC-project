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

        public IEnumerable<SelectListItem> ProjectDifficulties { get; set; }

        public int ProjectDifficulty { get; set; }

        public string ProjectDescription { get; set; }
    }
}