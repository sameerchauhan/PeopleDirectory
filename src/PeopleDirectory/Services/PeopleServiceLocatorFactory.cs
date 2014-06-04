using System;
using DAL;

namespace Services
{
    public class PeopleServiceLocatorFactory
    {
        private static IPeopleRepository _peopleRepository;

        public static IPeopleRepository GetPersonRepository()
        {
            return _peopleRepository ?? new PeopleRepository();
        }

        public static void SetRepository(IPeopleRepository peopleRepository)
        {
            if (peopleRepository == null) throw new ArgumentNullException("peopleRepository");
            _peopleRepository = peopleRepository;
        }
    }
}