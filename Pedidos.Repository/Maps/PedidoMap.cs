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
        }
    }
}
