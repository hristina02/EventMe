using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMe.Core.Models
{
    public class TownModel
    {
        ///<summary>
        /// Идентификатор на града
        /// </summary>
        public int Id { get; set; }

        ///<summary>
        /// Име на града
        /// </summary>
        public string Name { get; set; } = null!;
    }
}
