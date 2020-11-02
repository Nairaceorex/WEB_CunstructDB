using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ConstructDB.Models;

namespace CunstructDB.Data
{
    public class CunstructDBContext : DbContext
    {
        public CunstructDBContext (DbContextOptions<CunstructDBContext> options)
            : base(options)
        {
        }

        public DbSet<ConstructDB.Models.Staff> Staff { get; set; }

        public DbSet<ConstructDB.Models.TypeOfJob> TypeOfJob { get; set; }

        public DbSet<ConstructDB.Models.Position> Position { get; set; }

        public DbSet<ConstructDB.Models.Order> Order { get; set; }

        public DbSet<ConstructDB.Models.Material> Material { get; set; }

        public DbSet<ConstructDB.Models.Customer> Customer { get; set; }

        public DbSet<ConstructDB.Models.Brigade> Brigade { get; set; }
    }
}
