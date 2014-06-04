using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Domain;

namespace DAL
{
    public class PeopleRepository : IPeopleRepository
    {
        private readonly IEnumerable<Person> _data;

        public PeopleRepository()
        {
            _data = from line in File.ReadAllLines(@"C:\throwaway\PeopleDirectory\PeopleDirectory\DAL\People.txt").Skip(1)
                    let columns = line.Split(',')
                    select new Person
                    {
                        Name = columns[0],
                        DateOfBirth = DateTime.Parse(columns[1]),
                        BirthPlace = columns[2],
                        Height = int.Parse(columns[3]),
                        Weight = int.Parse(columns[4]),
                        AgeNextYear = AgeAtStartOfNextYear(DateTime.Parse(columns[1]))
                    };
        }

        public List<Person> GetListOfPeople()
        {
            return _data.ToList();
        }

        public Person GetPersonDetails(string name)
        {
            return _data.ToList().First(p => p.Name.Equals(name));
        }

        private int AgeAtStartOfNextYear(DateTime dateOfBirth)
        {
            var nextYear = new DateTime(DateTime.Now.Year + 1, 1, 1);
            var age =  nextYear.Year - dateOfBirth.Year;
            if (dateOfBirth > nextYear.AddYears(-age)) age--;
            return age;
        }
    }
}