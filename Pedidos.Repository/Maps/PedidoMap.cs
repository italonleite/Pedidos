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
    public class PedidoMap : BaseDomainMap<Pedido>
    {
        public PedidoMap() : base("Pedido") { }
        
        public override void Configure(EntityTypeBuilder<Pedido> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.Numero).HasColumnName("nome").HasMaxLength(10).IsRequired();
            builder.Property(x => x.ValorTotal).HasColumnName("preco").HasPrecision(17, 2).IsRequired();
            builder.Property(x => x.Entrega).HasColumnName("entrega");
        }
    }
}
