using Admin.DAL.Models.Base;
using Admin.DAL.Models.ManyToMany;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.DAL.Models
{
    /// <summary>
    /// Профессия
    /// </summary>
    public class Profession : DBItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProfessionId { get; set; }
        public ICollection<InterestProfession> Interests { get; set; }
    }
}
