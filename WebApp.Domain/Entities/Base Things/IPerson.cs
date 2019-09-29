using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Domain
{
    public interface IPerson
    {
        /// <summary>
        /// A name of a person
        /// </summary>
        string Name { get; set; }
    }
}
