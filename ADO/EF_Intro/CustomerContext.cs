using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace EF_Intro
{
    public partial class CustomerContext : DbContext
    {
        public CustomerContext()
            : base("name=CustomersModel")
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
