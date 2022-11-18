using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Models
{
    public class Pedido
    {
        public int nro;
        public string obs;
        public Cliente cliente;
        public string estado;

        public Pedido(Cliente cliente)
        {
            this.obs = "a";
            this.cliente = new Cliente();
            this.estado = "Pendiente";
        }
    }
}