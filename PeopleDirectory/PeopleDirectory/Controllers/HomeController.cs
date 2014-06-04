using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using PeopleDirectory.Models;
using Services;

namespace PeopleDirectory.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonService _service;

        public HomeController(IPersonService service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            var listOfPeople = _service.GetListOfPeople();
            var orderedList = Mapper.Map<List<PersonModel>>(listOfPeople).OrderBy(p => p.Name);
            return View(orderedList.ToList());
        }

        public ActionResult PersonDetails(string name)
        {
            var personDetails = Mapper.Map<PersonDetailsModel>(_service.GetPersonDetails(name));
            return View(personDetails);
        }
    }
}