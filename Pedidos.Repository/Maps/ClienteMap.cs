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
    public class ClienteMap : BaseDomainMap<Cliente>
    {
        public ClienteMap() : base("Cliente") { }
        
        public override void Configure(EntityTypeBuilder<Cliente> builder)
        {
            base.Configure(builder);
        }
    }
}
