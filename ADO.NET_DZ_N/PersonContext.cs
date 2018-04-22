namespace DzADO.NET
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class PersonContext : DbContext
    {
        public PersonContext()
            : base("name=PersonContext")
        {
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<AuthorBooks> AuthorBooks { get; set; }
    }
}