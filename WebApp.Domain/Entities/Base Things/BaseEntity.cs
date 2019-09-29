using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    /// <summary>
    /// Basic properties for everything
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// An id of a entity
        /// </summary>
        public int Id { get; set; }
    }
}
