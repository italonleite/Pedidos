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
    public class ProdutoMap : BaseDomainMap<Produto>
    {
        public ProdutoMap() : base("Produto") { }
        
        public override void Configure(EntityTypeBuilder<Produto> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").IsRequired();
            builder.Property(x => x.Codigo).HasColumnName("codigo").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Descricao).HasColumnName("descricao").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Preco).HasColumnName("preco").HasPrecision(17, 2).IsRequired();
            builder.Property(x => x.Ativo).HasColumnName("ativo").IsRequired();


        }
    }
}
