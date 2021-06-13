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
            builder.Property(x => x.Tipo).HasColumnName("tipo").IsRequired();
            builder.Property(x => x.Logradouro).HasColumnName("logradouro").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Bairro).HasColumnName("bairro").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Numero).HasColumnName("numero").HasMaxLength(10);
            builder.Property(x => x.Complemento).HasColumnName("complemento").HasMaxLength(50);
            builder.Property(x => x.Cep).HasColumnName("cep").HasMaxLength(8);

            //relacionamento 1 to 1
            builder.HasOne(x => x.Cliente).WithOne(x => x.Endereco).HasForeignKey<Cliente>(x => x.EnderecoId)

        }
    }
}
