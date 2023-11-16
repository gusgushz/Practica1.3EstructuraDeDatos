using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica1._3.Entities;

namespace Practica1._3.Entities
{
    internal class Biblioteca
    {
        Nodo? raiz;
        public Biblioteca()
        {
            raiz = null;
        }


        public void InsertarLibro(Libro libro)
        {
            raiz = InsertarRecursivo(raiz, libro);
        }

        Nodo InsertarRecursivo(Nodo nodo, Libro libro)
        {
            if (nodo == null)
            {
                return new Nodo(libro);
            }

            int comparacion = string.Compare(libro.ISBN, nodo.DatosLibro.ISBN, StringComparison.Ordinal);

            if (comparacion < 0)
                nodo.Izquierda = InsertarRecursivo(nodo.Izquierda, libro);
            else if (comparacion > 0)
                nodo.Derecha = InsertarRecursivo(nodo.Derecha, libro);

            return nodo;
        }
        public void EliminarLibro(string isbn)
        {
            raiz = EliminarRecursivo(raiz, isbn);
        }

        Nodo EliminarRecursivo(Nodo nodo, string isbn)
        {
            if (nodo == null)
            {
                return nodo;
            }

            int comparacion = string.Compare(isbn, nodo.DatosLibro.ISBN, StringComparison.Ordinal);

            if (comparacion < 0)
            {
                nodo.Izquierda = EliminarRecursivo(nodo.Izquierda, isbn);
            }
            else if (comparacion > 0)
            {
                nodo.Derecha = EliminarRecursivo(nodo.Derecha, isbn);
            }
            else
            {
                // Nodo a eliminar encontrado

                if (nodo.Izquierda == null && nodo.Derecha == null)
                {
                    // Caso 1: Nodo sin hijos
                    EliminarNodoSinHijos(ref nodo);
                }
                else if (nodo.Izquierda != null && nodo.Derecha != null)
                {
                    // Caso 3: Nodo con dos hijos
                    EliminarNodoConDosHijos(ref nodo);
                }
                else
                {
                    // Caso 2: Nodo con un hijo
                    EliminarNodoConUnHijo(ref nodo);
                }
            }

            return nodo;
        }
        Libro EncontrarMenorValor(Nodo nodo)
        {
            Libro minValor = nodo.DatosLibro;

            while (nodo.Izquierda != null)
            {
                minValor = nodo.Izquierda.DatosLibro;
                nodo = nodo.Izquierda;
            }

            return minValor;
        }
        void EliminarNodoSinHijos(ref Nodo nodo)
        {
            nodo = null; // Simplemente eliminamos el nodo.
        }
        void EliminarNodoConUnHijo(ref Nodo nodo)
        {
            Nodo hijoNoNulo = (nodo.Izquierda != null) ? nodo.Izquierda : nodo.Derecha;
            nodo = hijoNoNulo; // Reemplazamos el nodo con su único hijo.
        }
        void EliminarNodoConDosHijos(ref Nodo nodo)
        {
            nodo.DatosLibro = EncontrarMenorValor(nodo.Derecha);
            nodo.Derecha = EliminarRecursivo(nodo.Derecha, nodo.DatosLibro.ISBN);
        }

        public List<Libro> ObtenerListaPorAnchura()
        {
            List<Libro> listaLibros = new List<Libro>();

            if (raiz == null)
            {
                //Console.WriteLine("El árbol está vacío.");
                return listaLibros;
            }

            Queue<Nodo> cola = new Queue<Nodo>();
            cola.Enqueue(raiz);

            while (cola.Count > 0)
            {
                Nodo nodoActual = cola.Dequeue();
                listaLibros.Add(nodoActual.DatosLibro);

                if (nodoActual.Izquierda != null)
                {
                    cola.Enqueue(nodoActual.Izquierda);
                }

                if (nodoActual.Derecha != null)
                {
                    cola.Enqueue(nodoActual.Derecha);
                }
            }

            return listaLibros;
        }

        public List<Libro> BusquedaPreorden()
        {
            List<Libro> listaLibros = new List<Libro>();
            BusquedaPreordenRecursiva(raiz, listaLibros);
            return listaLibros;
        }

        private void BusquedaPreordenRecursiva(Nodo nodo, List<Libro> listaLibros)
        {
            if (nodo != null)
            {
                listaLibros.Add(nodo.DatosLibro);
                BusquedaPreordenRecursiva(nodo.Izquierda, listaLibros);
                BusquedaPreordenRecursiva(nodo.Derecha, listaLibros);
            }
        }

        public List<Libro> BusquedaInorden()
        {
            List<Libro> listaLibros = new List<Libro>();
            BusquedaInordenRecursiva(raiz, listaLibros);
            return listaLibros;
        }

        private void BusquedaInordenRecursiva(Nodo nodo, List<Libro> listaLibros)
        {
            if (nodo != null)
            {
                BusquedaInordenRecursiva(nodo.Izquierda, listaLibros);
                listaLibros.Add(nodo.DatosLibro);
                BusquedaInordenRecursiva(nodo.Derecha, listaLibros);
            }
        }

        public List<Libro> BusquedaPostorden()
        {
            List<Libro> listaLibros = new List<Libro>();
            BusquedaPostordenRecursiva(raiz, listaLibros);
            return listaLibros;
        }

        private void BusquedaPostordenRecursiva(Nodo nodo, List<Libro> listaLibros)
        {
            if (nodo != null)
            {
                BusquedaPostordenRecursiva(nodo.Izquierda, listaLibros);
                BusquedaPostordenRecursiva(nodo.Derecha, listaLibros);
                listaLibros.Add(nodo.DatosLibro);
            }
        }
    }
}
