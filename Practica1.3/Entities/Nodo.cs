using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._3.Entities
{
    internal class Nodo
    {
        public Libro DatosLibro;
        public Nodo? Izquierda, Derecha;
        public Nodo(Libro libro)
        {
            DatosLibro = libro;
            Izquierda = null;
            Derecha = null;
        }
    }
}
