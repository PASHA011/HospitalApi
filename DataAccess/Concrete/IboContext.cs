using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
   public class IboContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;Database=Patients;Trusted_connection=true;Integrated Security=true");
        }
       // public DbSet<Product> Products { get; set; }
        public DbSet<Patient> Patients { get; set; }

    }
}