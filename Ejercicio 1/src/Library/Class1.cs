using System;

namespace SRP
{
    public class Book
    {

        public string Title { get; }
        public string Author { get; }
        public string Code { get; }
        public BookLocation Location { get; }

        public Book(string title, string author, string code, BookLocation location)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
            this.Location = location;
        }

    }

    //Creo una clase nueva para la ubicación del libro porque se podría agregar una nueva categoría como por ejemplo
    //en qué biblioteca se encuentra o si está la versión física o virtual.
    public class BookLocation
    {

        public string LibrarySector { get; set; }
        public string LibraryShelf { get; set; }

        public BookLocation(string sector, string shelf)
        {
            this.LibrarySector = sector;
            this.LibraryShelf = shelf;
        }

    }
}