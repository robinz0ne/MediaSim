using Admin.DAL.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Admin.DAL.Models
{
    public class People: DBItem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid PeopleId { get; set; }

        /// <summary>
        /// Профессии
        /// </summary>
        public List<Profession> Professions { get; set; }

        /// <summary>
        /// Спортивные дисциплины
        /// </summary>
        public List<SportCategory> Sports { get; set; }

        /// <summary>
        /// Хобби
        /// </summary>
        public List<Hobby> Hobbies { get; set; }

        /// <summary>
        /// Возраст
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Является пенсионером
        /// </summary>
        public bool IsPensioner { get; set; }

        /// <summary>
        /// Женат
        /// </summary>
        public bool IsMarried { get; set; }

        /// <summary>
        /// Имеет детей
        /// </summary>
        public bool HaveKids { get; set; }

        /// <summary>
        /// Имеет живых родителей
        /// </summary>
        public bool HaveParents { get; set; }

    }
}
