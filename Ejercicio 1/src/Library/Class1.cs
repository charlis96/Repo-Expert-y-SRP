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
    /*
    En el código original no se cumplía el principio SRP, ya que la clase Book tenía más de una
    razón de cambio.

    Una razón de cambio sería que se podría agregar algún dato más de los libros, como por ejemplo
    la cantidad de páginas.

    Otra razón de cambio, podría ser que se decida agregar otro dato de la ubicación, como por ejemplo
    en qué biblioteca se encuentra o si el libro está en versión física o virtual.

    Creo una clase nueva para la ubicación del libro para que la clase Book sólo tenga una razón
    de cambio.
    */
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