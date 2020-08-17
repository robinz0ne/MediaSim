using System;

namespace Admin.DAL.Models.ManyToMany
{
    public class InterestHobby
    {
        public Guid HobbyId { get; set; }
        public Hobby Hobby { get; set; }
        public Guid InterestId { get; set; }
        public Interest Interest { get; set; }
    }
}
