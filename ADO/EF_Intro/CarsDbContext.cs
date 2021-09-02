using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Intro
{
    class CarsDbContext : DbContext
    {
        public CarsDbContext() 
            : base("DbConnection")
        {   }

        public DbSet<Car> Cars { get; set; }
    }
}
