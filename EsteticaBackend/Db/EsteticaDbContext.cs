using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EsteticaBackend.Db
{
    public class EsteticaDbContext : BaseDbContext
    {
        public EsteticaDbContext(DbContextOptions options) : base(options)
        {
            base.Database.EnsureCreated();
        }

        //DbSets

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurations
        }
    }
}
