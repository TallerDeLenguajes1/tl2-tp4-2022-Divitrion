using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Models
{
    public class Cadete : Persona
    {
        public List<Pedido> listadoPedidos;
        public int id;

        public void JornalACobrar()
        {
            
        }

        public Cadete()
        {
            listadoPedidos=new List<Pedido>();
            id++;
        }

        public void recibirPedido(Pedido pedido)
        {
            listadoPedidos.Add(pedido);
        }
    }
}