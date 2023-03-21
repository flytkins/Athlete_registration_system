using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication8.Classes
{
    class AppContext : DbContext
    {
        public AppContext()
            :base("DbConnection")
        { }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Person> Employees { get; set; }
        public DbSet<Person> Judges { get; set; }
        public DbSet<Person> Sportsmans { get; set; }
        public DbSet<Person> Events { get; set; }
        public DbSet<Person> Categories { get; set; }
        public DbSet<Person> Results { get; set; }
    }
}
