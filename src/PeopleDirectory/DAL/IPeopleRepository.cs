using System.Collections.Generic;
using Domain;

namespace DAL
{
    public interface IPeopleRepository
    {
        List<Person> GetListOfPeople();

        Person GetPersonDetails(string name);
    }
}