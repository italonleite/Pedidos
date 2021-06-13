using Pedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Entities
{
    public class Cliente : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco { get; set; }
        public bool Ativo { get; set; }
    }
}
