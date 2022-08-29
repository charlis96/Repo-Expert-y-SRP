using System;

namespace SRP
{
    public class Book
    {
        public string Title { get; }
        public string Author { get; }
        public string Code { get; }

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
    }
    
    /*
    Puedo crear una nueva clase por si quiero especificar en qué biblioteca se encuentra el libro (Central, Mullin, etc.), y también
    por ejemplo si el libro está online en vez de físico.
    */
    public class Location
    {
        public string LibrarySector { get; set; }
        public string LibraryShelve { get; set; }
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
    }
}