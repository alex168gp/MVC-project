using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApp.Domain
{
    /// <summary>
    /// A client of a company that suggested a project
    /// </summary>
    public class Client: BaseEntity, IPerson
    {
        #region Public Properties

        /// <summary>
        /// A name of a client
        /// </summary>
        public string Name { get; set; }

        [EmailAddress]
        /// <summary>
        /// An email of a client
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// A number of a client
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// A project that client ordered
        /// </summary>
        public Project Project { get; set; } 

        #endregion
    }
}