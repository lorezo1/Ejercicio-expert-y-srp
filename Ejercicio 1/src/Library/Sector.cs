using System; 
using System.Collections.Generic;

namespace SRP
{
    public class Sector
    {
        public string Letra { get ; }

        public List<Shelve> ListaEstanteria = new List<Shelve>{};

//Se crea lista de estanteria para agregar al sector

        public Sector (string Letra)
        {
            this.Letra = Letra;
            
        }


        public void AddEstanteria (Shelve Estanteria)
        {
            ListaEstanteria.Add(Estanteria);
        }

         public void RemoveEstanteria (Shelve Estanteria)
        {
            ListaEstanteria.Remove(Estanteria);
        }

    }

}