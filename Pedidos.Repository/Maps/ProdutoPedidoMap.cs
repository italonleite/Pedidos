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
    public class ProdutoPedidoMap : BaseDomainMap<ProdutoPedido>
    {
        public ProdutoPedidoMap() : base("ProdutoPedido") { }
        
        public override void Configure(EntityTypeBuilder<ProdutoPedido> builder)
        {
            base.Configure(builder);
        }
    }
}
