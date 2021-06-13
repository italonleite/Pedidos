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
        }
    }
}
