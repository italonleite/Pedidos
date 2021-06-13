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
    public class EnderecoMap : BaseDomainMap<Endereco>
    {
        public EnderecoMap() : base("Endereco") { }
        
        public override void Configure(EntityTypeBuilder<Endereco> builder)
        {
            base.Configure(builder);
        }
    }
}
