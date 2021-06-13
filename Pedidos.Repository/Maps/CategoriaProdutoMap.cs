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
    public class CategoriaProdutoMap : BaseDomainMap<CategoriaProduto>
    {
        public CategoriaProdutoMap() : base("Cidade") { }
        
        public override void Configure(EntityTypeBuilder<CategoriaProduto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();           
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();

        }
    }
}
