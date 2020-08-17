using Admin.DAL.Models.Base;
using Admin.DAL.Models.ManyToMany;
using System;
using System.Collections.Generic;

namespace Admin.DAL.Models
{
    /// <summary>
    /// Интерес
    /// </summary>
    public class Interest : DBItem
    {
        public Guid InterestId { get; set; }
        /// <summary>
        /// Профессиональный
        /// </summary>
        public bool IsProfessional { get; set; }

        /// <summary>
        /// Спортивный
        /// </summary>
        public bool IsSport { get; set; }

        /// <summary>
        /// Хобби
        /// </summary>
        public bool IsHobby { get; set; }

        /// <summary>
        /// Дороговизна (0 - Дешевое, 1 - Затратное, 2 - Дорогое)
        /// </summary>
        public int HighCosts { get; set; }

        /// <summary>
        /// Затраты времени в процентах
        /// </summary>
        public int TimePercent { get; set; }

        public ICollection<InterestHobby> Hobbies { get; set; }
        public ICollection<InterestProfession> Professions { get; set; }
        public ICollection<InterestSportCategory> SportCategories { get; set; }
    }
}
