using System.Collections.Generic;
using PeopleSearch.Models;

namespace PeopleSearch.Services
{
    public interface IPeopleService
    {
        IEnumerable<Person> GetPeople();
    }
}