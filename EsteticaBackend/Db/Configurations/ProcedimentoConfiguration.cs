using EsteticaBackend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsteticaBackend.Db.Configurations
{
    public class ProcedimentoConfiguration : IEntityTypeConfiguration<Procedimento>
    {
        public void Configure(EntityTypeBuilder<Procedimento> builder)
        {
            builder.ToTable("Procedimento");

            builder.HasKey(p => p.ProcedimentoId);

            builder.Property(p => p.ProcedimentoId)
                .IsRequired()
                .UseSqlServerIdentityColumn();
        }
    }
}
