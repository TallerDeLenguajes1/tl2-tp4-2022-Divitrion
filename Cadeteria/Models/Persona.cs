using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cadeteria.Models
{
    public class Persona
    {
        public string nombre;
        protected string direccion;
        protected string telefono;

        public Persona()
        {
            this.nombre="x";
            this.direccion="direccion";
            this.telefono="telefonito";
        }
    }
}