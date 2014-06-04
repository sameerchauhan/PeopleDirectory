using System.Collections.Generic;
using AutoMapper;
using Domain;

namespace Services
{
    public class PersonService : IPersonService
    {
        public PersonService()
        {
            Mapper.CreateMap<Person,PersonDto>(); //Move to a bootstrapper
            Mapper.CreateMap<Person, PersonDetailsDto>(); //Move to a bootstrapper
        }

        public List<PersonDto> GetListOfPeople()
        {
            var repo = PeopleServiceLocatorFactory.GetPersonRepository(); //Replace with correct WCF Unity implementation
            var list=Mapper.Map<List<PersonDto>>(repo.GetListOfPeople());
            return list;
        }

        public PersonDetailsDto GetPersonDetails(string name)
        {
            var repo = PeopleServiceLocatorFactory.GetPersonRepository(); //Replace with correct WCF Unity implementation
            var person = Mapper.Map<PersonDetailsDto>(repo.GetPersonDetails(name));
            return person;
        }
    }
}
