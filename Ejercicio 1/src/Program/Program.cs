using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
      //      book1.ShelveBook("A","7");
      //      book2.ShelveBook("B","3");

            Sector SectorA = new Sector ("A");
            Shelve Shelve7 = new Shelve ("7");

            Shelve7.AddBook(book1);
            SectorA.AddEstanteria(Shelve7);
            
            
            Sector SectorB = new Sector ("B");
            Shelve Shelve3 = new Shelve ("3");

            Shelve3.AddBook(book2);
            SectorB.AddEstanteria(Shelve3);
        }
    }
}