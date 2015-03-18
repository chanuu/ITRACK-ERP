using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITRACK.models
{
    public class ItrackContext : DbContext

    {

        public ItrackContext()
            : base("AppDbContext")
        {
            //Create database always, even If exists
            Database.SetInitializer<ItrackContext>(new ItrackContextInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

        }

        public DbSet<Group> Group { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Buyer> Buyer { get; set; }

        public DbSet<Style> Style { get; set; }

        public DbSet<SketchDefinition> SketchDefinition { get; set; }

        public DbSet<User> User { get; set; }
    }
}
