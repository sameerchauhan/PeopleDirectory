using System;

namespace PeopleDirectory.Models
{
    public class PersonDetailsModel
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BirthPlace { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }
        public int AgeNextYear { get; set; }
    }
}