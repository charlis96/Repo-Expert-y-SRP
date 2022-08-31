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

    public class BookLocation
    {

        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public BookLocation(string sector, string shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }

    }
}