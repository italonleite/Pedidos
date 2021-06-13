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

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(20).IsRequired();
            builder.Property(x => x.NomeArquivo).HasColumnName("nome_arquivo").HasMaxLength(20).IsRequired();
            builder.Property(x => x.Principal).HasColumnName("principal").IsRequired();


        }
    }
}
