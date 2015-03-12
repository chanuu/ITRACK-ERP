using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTesting
{
    class AppDbContext :DbContext
    {
        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
