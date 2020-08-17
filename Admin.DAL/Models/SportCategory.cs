using Admin.DAL.Models.Base;
using Admin.DAL.Models.ManyToMany;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.DAL.Models
{
    /// <summary>
    /// Спортивная категория
    /// </summary>
    public class SportCategory : DBItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SportCategoryId { get; set; }
        public bool IsProfessional { get; set; }
        public Profession Profession { get; set; }
        public ICollection<InterestSportCategory> Interests { get; set; }
    }
}
