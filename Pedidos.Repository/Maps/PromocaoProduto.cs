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
    public class PromocaoProdutoMap : BaseDomainMap<PromocaoProduto>
    {
        public PromocaoProdutoMap() : base("PromocaoProduto") { }
        
        public override void Configure(EntityTypeBuilder<PromocaoProduto> builder)
        {
            base.Configure(builder);
        }
    }
}
