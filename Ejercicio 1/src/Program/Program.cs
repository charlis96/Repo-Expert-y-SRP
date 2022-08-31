using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034",new BookLocation("A","7"));
            Book book2 = new Book("Pro C#","Troelsen","001-035",new BookLocation("B","3"));
        }
    }
}