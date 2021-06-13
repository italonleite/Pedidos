using Pedidos.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Entities
{
    public class Pedido : BaseDomain
    {
        public string Numero { get; set; }
        public decimal ValorTotal { get; set; }
        public TimeSpan Entrega { get; set; }
        public int ClienteId { get; set; }
        public virtual Cliente Cliente { get; set; }
        public List<ProdutoPedido> Produtos { get; set; }      
        
    }
}
