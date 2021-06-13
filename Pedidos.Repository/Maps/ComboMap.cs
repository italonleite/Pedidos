using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Pedidos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Repository.Maps
{
    public class ComboMap : BaseDomainMap<Combo>
    {
        public ComboMap() : base("Combo") { }
        
        public override void Configure(EntityTypeBuilder<Combo> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Preco).HasColumnName("preco").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();
        }
    }
}
