using System;

namespace Admin.DAL.Models.ManyToMany
{
    public class InterestSportCategory
    {
        public Guid SportCategoryId { get; set; }
        public SportCategory SportCategory { get; set; }
        public Guid InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
