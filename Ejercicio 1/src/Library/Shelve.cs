using System; 
using System.Collections.Generic;

namespace SRP
{
    public class Shelve
    {
        public string Numero { get ; }

        public List<Book> ListaLibros = new List<Book>{};

//Se crea lista de libros para agregar a la estanteria

        public Shelve (string Numero)
        {
            this.Numero = Numero;
            
        }


        public void AddBook (Book Libro)
        {
            ListaLibros.Add(Libro);
        }

         public void RemoveLibros (Book Libro)
        {
            ListaLibros.Remove(Libro);
        }

    }

}