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
    public class CidadeMap : BaseDomainMap<Cidade>
    {
        public CidadeMap() : base("Cidade") { }
        
        public override void Configure(EntityTypeBuilder<Cidade> builder)
        {
            base.Configure(builder);
        }
    }
}
