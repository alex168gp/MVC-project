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
            if (!ModelState.IsValid)
            {
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

            using (CompanyContext company = new CompanyContext())
            {

                Project project = new Project
                {
                    Name = projectOrder.ProjectName,
                    Description = projectOrder.ProjectDescription,
                    Difficulty = projectOrder.ProjectDifficulty
                };
                
                company.Clients.Add(new Client
                {
                    Name = projectOrder.ClientName,
                    Email = projectOrder.ClientEmail,
                    CurrentProject = project
                });
                company.Projects.Add(project);

                var teamMembers = company.Employees.Where(employee => employee.Availability == true).Take(project.Difficulty * 3).ToList();
                teamMembers.ForEach(employee => employee.ProjectCount++);

                company.ProjectTeams.Add(new ProjectTeam
                {
                    CurrentProject = project,
                    Employees = teamMembers
                });
                
                company.SaveChanges();
            }

            return RedirectToAction("OrderResult", projectOrder);
        }

        public ActionResult OrderResult(ProjectOrder projectOrder)
        {
            Project project;
            List<Employee> projectTeam;
            using (CompanyContext company = new CompanyContext())
            {
                project = company.Projects.ToList().LastOrDefault();
                projectTeam = company.ProjectTeams.Where(team => team.CurrentProject.Id == project.Id).SelectMany(team => team.Employees).ToList();
            }
            var orderInformation = new ProjectOrderInformation();
            orderInformation.StartDate = project.StartDate;
            orderInformation.ProjectTimeDuration = project.ProjectTimeDuration;
            orderInformation.Employees = projectTeam;
            return View(orderInformation);
        }

        public ActionResult ProjectsShow()
        {
            List<Project> projects;
            using (CompanyContext company = new CompanyContext())
            {
                projects = company.Projects.ToList();
            }

            ProjectsShow projectsShow = new ProjectsShow();
            if (projects == null)
            {
                projectsShow.Projects = new List<Project>();
            }
            else
            {
                projectsShow.Projects = projects;
            }

            return View(projectsShow);
        }
    }
}