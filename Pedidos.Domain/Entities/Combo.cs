using Pedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Entities
{
    public class Combo : BaseDomain, IExibivel
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int ImagemId { get; set; }
        public Imagem Imagem { get; set; }
        public List<Produto> Produtos { get; set; }
        public bool Ativo { get; set; }
    }
}
