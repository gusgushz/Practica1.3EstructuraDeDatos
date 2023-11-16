using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1._3.Entities
{
    internal class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int AñoPublicacion { get; set; }
        public string ISBN { get; set; }
        public Libro(string titulo, string autor, int añoPublicacion, string isbn)
        {
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            ISBN = isbn;
        }
    }
}
/*
 Catálogo de Libros
Imagina que estás desarrollando un sistema para gestionar un catálogo de libros en una biblioteca. La biblioteca tiene una 
gran cantidad de libros, y se desea implementar un sistema eficiente para buscar libros por su número de ISBN (International 
Standard Book Number).
Se te pide que utilices un árbol de búsqueda binario para organizar el catálogo de libros por ISBN. Cada nodo del árbol representará un 
libro, y los nodos se organizarán de manera que los libros con ISBN más pequeños estén a la izquierda y los libros con ISBN más grandes 
estén a la derecha. 
La aplicación debe permitir realizar búsquedas rápidas de libros por su número de ISBN, agregar nuevos libros al catálogo, eliminar 
libros y mostrar el catálogo ordenado según el número de ISBN.
Este problema te desafiará a implementar las operaciones básicas de un árbol de búsqueda binario (inserción, eliminación, búsqueda) 
y a diseñar una interfaz que permita una gestión eficiente del catálogo de libros en la biblioteca.
*/
