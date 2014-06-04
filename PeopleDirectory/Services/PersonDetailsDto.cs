using System;
using System.Runtime.Serialization;

namespace Services
{
    [DataContract]
    public class PersonDetailsDto
    {
        [DataMember]
        public string Name { get; set; }
        
        [DataMember]
        public DateTime DateOfBirth { get; set; }
        
        [DataMember]
        public string BirthPlace { get; set; }
        
        [DataMember]
        public int Height { get; set; }
        
        [DataMember]
        public int Weight { get; set; }
        
        [DataMember]
        public int AgeNextYear { get; set; }
    }
}