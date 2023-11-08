using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ado3
{
    public class PersonContext : DbContext
    {
        public PersonContext(): base("Person") {}
        public DbSet<Person> Persons { get; set; }
    }
}