using Admin.DAL.Models.Base;
using Admin.DAL.Models.ManyToMany;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.DAL.Models
{
    /// <summary>
    /// Хобби
    /// </summary>
    public class Hobby : DBItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid HobbyId { get; set; }
        public ICollection<InterestHobby> Interests { get; set; }
    }
}
