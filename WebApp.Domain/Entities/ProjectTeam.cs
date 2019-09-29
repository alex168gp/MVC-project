using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Domain
{
    /// <summary>
    /// A team that work under a project
    /// </summary>
    public class ProjectTeam: BaseEntity
    {
        #region Public Properties

        /// <summary>
        /// A project the team is working on
        /// </summary>
        public Project Project { get; set; }

        /// <summary>
        /// When team started to work on a project
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Estimated time that need team to complete project
        /// </summary>
        public DateTime ProjectTimeDuration { get; set; }

        /// <summary>
        /// A list of employees that work on a project
        /// </summary>
        public ICollection<Employee> Employees { get; set; }

        /// <summary>
        /// A maximum of employees that could be in a team
        /// </summary>
        public int MaxCapacity { get; set; } = 3;

        #endregion
    }
}