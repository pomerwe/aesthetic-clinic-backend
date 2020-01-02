using EsteticaBackend.Db;
using EsteticaBackend.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace EsteticaBackend.Services
{
    public sealed class MainService
    {
        private readonly IServiceScopeFactory scopeFactory;

        public MainService(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
        }

        public List<Cliente> GetClientes()
        {
            using(var dbContext = this.scopeFactory.CreateScope().ServiceProvider.GetRequiredService<EsteticaDbContext>())
            {
                return dbContext.Clientes.ToList();
            }
        }

        public Cliente SaveCliente(Cliente cliente)
        {
            using(var dbContext = this.scopeFactory.CreateScope().ServiceProvider.GetRequiredService<EsteticaDbContext>())
            {
                return dbContext.AddOrUpdate(cliente);
            }
        }
    }
}
