using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Models
{
    public class Cliente : Persona
    {
         public string DatoReferenciaDireccion;
        public int cantPedidos;

        public Cliente()
        {
            this.DatoReferenciaDireccion="referencias";
            cantPedidos= 0;
        }
    }
}