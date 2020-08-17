using System;
using System.Text.Json.Serialization;

namespace Admin.UI.Models
{
    public class People 
    {
        [JsonPropertyName("peopleId")]
        public Guid PeopleId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("age")]
        public int Age { get; set; }

        [JsonPropertyName("isPensioner")]
        public bool IsPensioner { get; set; }

        [JsonPropertyName("isMarried")]
        public bool IsMarried { get; set; }

        [JsonPropertyName("haveKids")]
        public bool HaveKids { get; set; }

        [JsonPropertyName("haveParents")]
        public bool HaveParents { get; set; }
    }
}
