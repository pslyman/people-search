using Microsoft.EntityFrameworkCore;
using PeopleSearch.Models;

namespace PeopleSearch.Context
{
    public interface IPeopleContext
    {
        DbSet<Person> People { get; set; }
    }
}