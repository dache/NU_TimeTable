using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.DAL
{
    public class NuContext : DbContext
    {
        public NuContext() : base("NuContext")
        {            
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Person> People { get; set; }
    }
}
