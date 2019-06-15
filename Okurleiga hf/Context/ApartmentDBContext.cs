using Okurleiga_hf.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okurleiga_hf.Context
{
    class ApartmentDBContext : DbContext
    {
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<ApartmentOwner> ApartmentOwners { get; set; }        
        public DbSet<ApartmentIncident> ApartmentIncidents { get; set; }        
        public DbSet<Customer> Customers { get; set; }        
        public DbSet<Employee> Employees { get; set; }        
        public DbSet<Rent> Rents { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    // Þetta segir að ApartmentOwners geti átt margar íbúðir
        //    modelBuilder.Entity<ApartmentOwner>().HasMany(ao => ao.Apartments);
        //    modelBuilder.Entity<Employee>().HasMany(e => e.Rents);
        //}
    }
}
