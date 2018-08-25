using Microsoft.EntityFrameworkCore;
using PeopleSearch.Models;

namespace PeopleSearch.Context
{
    public class PeopleContext : DbContext, IPeopleContext
    {
        public PeopleContext(DbContextOptions<PeopleContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>().HasData(
              new Person { Id = 1, Name = "Jared Johnson", Age = 33, Eyecolor = "Blue", Address = "1234 Avenue", Fact = "Likes ketchup on most everything", Image = "https://api.adorable.io/avatars/285/jared@adorable.io.png" },
              new Person { Id = 2, Name = "Katherine Ayne", Age = 21, Eyecolor = "Brown", Address = "1234 Pkwy", Fact = "Saw a kangaroo once", Image = "https://api.adorable.io/avatars/285/katherine@adorable.io.png" },
              new Person { Id = 3, Name = "Katy Courts", Age = 45, Eyecolor = "Brown", Address = "1234 Cir", Fact = "Reads LotR fan-fiction for fun", Image = "https://api.adorable.io/avatars/285/katy@adorable.io.png" },
              new Person { Id = 4, Name = "James Hansen", Age = 32, Eyecolor = "Green", Address = "1234 Way", Fact = "Writes a lot of LotR fan-fiction", Image = "https://api.adorable.io/avatars/285/james@adorable.io.png" },
              new Person { Id = 5, Name = "Jonathan Greendale", Age = 70, Eyecolor = "Blue", Address = "1234 St", Fact = "Uses peppermint toothpaste like a weirdo", Image = "https://api.adorable.io/avatars/285/jonathan@adorable.io.png" },
              new Person { Id = 6, Name = "Jessica Fern", Age = 20, Eyecolor = "Hazel", Address = "1234 Road", Fact = "Grows her own parsley in her backyard", Image = "https://api.adorable.io/avatars/285/jessica@adorable.io.png" },
              new Person { Id = 7, Name = "Jordan Kale", Age = 50, Eyecolor = "Hazel", Address = "1234 Ln", Fact = "Owns three gorgeous cats: Fergeson, Jeffrey, and Monica", Image = "https://api.adorable.io/avatars/285/jordan@adorable.io.png" }
            );
        }
    }
}
