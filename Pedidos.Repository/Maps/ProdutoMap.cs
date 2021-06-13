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
        }
    }
}
