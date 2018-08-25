using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PeopleSearch.Models;
using PeopleSearch.Services;

namespace PeopleSearch.Controllers
{
    [Route("api/[controller]")]
    public class PeopleController : Controller
    {
        private readonly IPeopleService _peopleService;

        public PeopleController(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }
        
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return _peopleService.GetPeople();
        }
    }
}
