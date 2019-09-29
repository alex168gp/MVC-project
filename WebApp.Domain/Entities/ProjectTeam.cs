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
        #region Private Members

        /// <summary>
        /// A project the team is working on
        /// </summary>
        private Project mCurrentProject; 

        #endregion
        #region Public Properties

        /// <summary>
        /// A project the team is working on
        /// </summary>
        public Project CurrentProject
        {
            get => mCurrentProject;
            set
            {
                // Maximum number of employees depends on a project difficulty, 3 per level
                MaxCapacity = value.Difficulty * 3;

                // set value
                mCurrentProject = value;
            }
        }

        /// <summary>
        /// A list of employees that work on a project
        /// </summary>
        public ICollection<Employee> Employees { get; set; }

        /// <summary>
        /// A maximum of employees that could be in a team
        /// </summary>
        public int MaxCapacity { get; private set; } = 3;

        #endregion
    }
}