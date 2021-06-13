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
    public class ImagemMap : BaseDomainMap<Imagem>
    {
        public ImagemMap() : base("Imagem") { }
        
        public override void Configure(EntityTypeBuilder<Imagem> builder)
        {
            base.Configure(builder);
        }
    }
}
