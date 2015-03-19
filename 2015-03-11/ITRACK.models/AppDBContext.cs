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

      

        public DbSet<Group> Group { get; set; }

        public DbSet<Company> Company { get; set; }

        public DbSet<Buyer> Buyer { get; set; }

        public DbSet<Style> Style { get; set; }

        public DbSet<SketchDefinition> SketchDefinition { get; set; }

        public DbSet<User> User { get; set; }


        public DbSet<PurchaseOrderHeader> PurchaseOrderHeader { get; set; }


        public DbSet<PurchaseOrderItems> PurchaseOrderItems { get; set; }

        public DbSet<Employee> Employee { get; set; }

        public DbSet<Promotion> Promotion { get; set; }

        public DbSet<Award> Award { get; set; }

        public DbSet<PastEmployeement> PastEmployeement { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();


            //create one to one or one to zero replationsip in Employee - user Entity
            modelBuilder.Entity<User>()
                            .HasKey(t => t.UserID);

            modelBuilder.Entity<Employee>()
                .HasRequired(t => t.User)
                .WithRequiredPrincipal(t => t.Employee);


            //create one to one or one to zero replationsip in Employee - Workstation Entity
            modelBuilder.Entity<Workstation>()
                            .HasKey(t => t.WorkstationID);

            modelBuilder.Entity<Employee>()
                .HasRequired(t => t.Workstation)
                .WithRequiredPrincipal(t => t.Employee);

        }

    }
}
