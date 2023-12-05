using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMe.Infrastructure.Data.Models
{
    /// <summary>
    /// Град
    /// </summary>
    [Comment("Град")]
    public class Town
    {
        /// <summary>
        /// Идентификатор на града
        /// </summary>
        [Key]
        [Comment("Идентификатор на града")]
        public int Id { get; set; }

        /// <summary>
        /// Име на града
        /// </summary>
        [Required]
        [Comment("Име на града")]
        [MaxLength(50)]
        public string Name { get; set; } = null!;
    }
}
