using EsteticaBackend.Db;
using EsteticaBackend.Models;
using Microsoft.EntityFrameworkCore;
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
        private EsteticaDbContext dbContext;

        public MainService(IServiceScopeFactory scopeFactory)
        {
            this.scopeFactory = scopeFactory;
            dbContext = this.scopeFactory.CreateScope().ServiceProvider.GetRequiredService<EsteticaDbContext>();
        }

        public List<Cliente> GetClientes()
        {
            return dbContext.Clientes.Include(c => c.Telefones).ToList();
        }

        public Cliente SaveCliente(Cliente cliente)
        {
           return dbContext.AddOrUpdate(cliente);
        }

        public Cliente GetCliente(int pessoaId)
        { 
           return dbContext.Clientes.Include(c => c.Telefones).FirstOrDefault(c => c.PessoaId == pessoaId);
        }

        public List<Profissional> GetProfissionais()
        {
            return dbContext.Profissionais.Include(c => c.Telefones).ToList();
        }

        public Profissional SaveProfissional(Profissional profissional)
        {
          return dbContext.AddOrUpdate(profissional);
        }

        public Profissional GetProfissional(int pessoaId)
        {
           return dbContext.Profissionais.Include(c => c.Telefones).FirstOrDefault(c => c.PessoaId == pessoaId);
        }

        public Pessoa GetPessoa(int pessoaId)
        {
            Pessoa pessoa = null;

            pessoa = GetCliente(pessoaId);

            if(pessoa != null)
            {
                return pessoa;
            }

            pessoa = GetProfissional(pessoaId);

            return pessoa;
        }
    }
}
