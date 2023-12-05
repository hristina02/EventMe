using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMe.Infrastructure.Data.Contracts
{

    /// <summary>
    /// Entity което може да бъде изтрито
    /// </summary>
    public interface IDeletable
    {
        /// <summary>
        /// Записът е активен
        /// </summary>
        bool IsActive { get; set; }

        /// <summary>
        /// Дата на изтриване
        /// </summary>
        DateTime? DeletedOn { get; set; }
    }
}
