using System;

namespace Admin.DAL.Models.ManyToMany
{
    public class InterestProfession
    {
        public Guid ProfessionId { get; set; }
        public Profession Profession { get; set; }
        public Guid InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
