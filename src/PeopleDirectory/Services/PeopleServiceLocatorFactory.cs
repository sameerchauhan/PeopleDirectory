using System;
using System.IO;
using System.Web.Hosting;
using DAL;

namespace Services
{
    public class PeopleServiceLocatorFactory
    {
        private static IPeopleRepository _peopleRepository;

        public static IPeopleRepository GetPersonRepository()
        {
            string dataLocation = Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "App_Data", "People.txt");
            return _peopleRepository ?? new PeopleRepository(dataLocation);
        }

        public static void SetRepository(IPeopleRepository peopleRepository)
        {
            if (peopleRepository == null) throw new ArgumentNullException("peopleRepository");
            _peopleRepository = peopleRepository;
        }
    }
}