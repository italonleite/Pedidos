using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Domain.Entities
{
    //abstract - só pode ser herdada.
    public abstract class BaseDomain 
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}
