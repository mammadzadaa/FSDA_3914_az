using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework
{
    class CarsContext : DbContext
    {

        public CarsContext() : base() { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString);
        }

        public DbSet<Car> Cars { get; set; }

    }
}
