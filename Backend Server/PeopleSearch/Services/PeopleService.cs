using PeopleSearch.Context;
using PeopleSearch.Models;
using System.Collections.Generic;

namespace PeopleSearch.Services
{
  public class PeopleService : IPeopleService
    {
        private readonly IPeopleContext _peopleContext;

        public PeopleService(IPeopleContext peopleContext)
        {
            _peopleContext = peopleContext;
        }

        public IEnumerable<Person> GetPeople()
        {
            return _peopleContext.People;
        }
    }
}
