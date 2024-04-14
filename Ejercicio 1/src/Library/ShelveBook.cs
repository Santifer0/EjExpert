using System.Collections.Generic;

namespace Ucu.Poo.Expert
{

    public class ShelveBook
    {
        public string LibraryShelve { get ; set; }
        private List<Book> Books;
        
        public ShelveBook(string shelve)
        {
            this.LibraryShelve = shelve;
            this.Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            this.Books.Add(book);
        }

    }
}