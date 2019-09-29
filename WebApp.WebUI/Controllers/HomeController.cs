using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Domain;

namespace WebApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Dif = -1;
            var projectOrder = new ProjectOrder();
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            for (int i = 0; i < 5; i++)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = (i + 1).ToString(),
                    Value = (i + 1).ToString()
                });
            }
            projectOrder.ProjectDifficulties = selectListItems;
            return View(projectOrder);
        }

        [HttpPost]
        public ActionResult Index(ProjectOrder projectOrder)
        {
            using (CompanyContext company = new CompanyContext())
            {

                /*
                company.Clients.Add(new Client
                {
                    Name = projectOrder.ClientName
                    //Email = projectOrder.ClientEmail
                });
                Project project = new Project
                {
                    Name = projectOrder.ProjectName,
                    Description = projectOrder.ProjectDescription,
                    Difficulty = projectOrder.ProjectDifficulty
                };
                company.Projects.Add(project);
                company.ProjectTeams.Add(new ProjectTeam
                {
                    CurrentProject = project,
                    Employees = company.Employees.Where(employee => employee.Availability == true).Take(project.Difficulty*3).ToList()
                });
                */
                ViewBag.Dif = projectOrder.ProjectDifficulty;
                company.SaveChanges();
            }
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            for (int i = 0; i < 5; i++)
            {
                selectListItems.Add(new SelectListItem
                {
                    Text = (i + 1).ToString(),
                    Value = (i + 1).ToString()
                });
            }
            projectOrder.ProjectDifficulties = selectListItems;
            return View(projectOrder);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}