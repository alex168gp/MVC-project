using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Domain
{
    /// <summary>
    /// An employee of a company
    /// </summary>
    public class Employee : BaseEntity, IPerson
    {
        #region Private Members

        /// <summary>
        /// In how many projects employee participates
        /// </summary>
        private int mProjectCount = 0;

        #endregion

        #region Public Properties

        [Required]
        /// <summary>
        /// A name of an employee
        /// </summary>
        public string Name { get; set; }


        [EmailAddress]
        /// <summary>
        /// An email of an employee
        /// </summary>
        public string Email { get; set; }


        /// <summary>
        /// In how many projects employee participates
        /// </summary>
        public int ProjectCount
        {
            get
            {
                // get property
                return mProjectCount;
            }
            set
            {
                // If employee can't take more projects
                if (!Availability)
                {
                    Console.WriteLine("He's not available");
                    return;
                }

                // An employee can be only in limited number of projects
                if (value >= 0 && value <= MaxProjects)
                {
                    // set value if employee can take more projects
                    mProjectCount = value;

                    // if employee already has 3 projects
                    if (value == MaxProjects)
                        // he's too busy and not available anymore, otherwise...
                        Availability = false;
                    else
                        // he's available
                        Availability = true;
                }
                else
                {
                    // Otherwise we should notify someone and somehow
                    Console.WriteLine("Something went wrong");
                }
            }
        }

        /// <summary>
        /// Shows if employee can participate in a new project
        /// </summary>
        public bool Availability { get; private set; } = true;

        /// <summary>
        /// A maximum count of projects the employee can take
        /// </summary>
        public int MaxProjects { get; set; } = 3;

        /// <summary>
        /// Teams that employee is a part of
        /// </summary>
        public ICollection<ProjectTeam> Teams { get; set; }

        #endregion
    }
}