using System;
using System.Runtime.Serialization;

namespace Services
{
    [DataContract]
    public class PersonDto
    {       
        [DataMember]
        public string Name { get; set; }
    }
}