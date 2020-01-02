using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EsteticaBackend.Db.Configurations;
using EsteticaBackend.Models;
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
        public DbSet<Profissional> Profissionais { get; set; }
        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurations
            modelBuilder.ApplyConfiguration(new PessoaConfiguration());
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
            modelBuilder.ApplyConfiguration(new ProfissionalConfiguration());
        }

        
    }
}
