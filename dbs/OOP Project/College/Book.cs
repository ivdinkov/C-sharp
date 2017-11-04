using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    public class Book
    {
        private string status;
        public string BookId { get; private set; }
        public string BookIsbn { get; private set; }
        public string BookName { get; private set; }
        public string BookAuthor { get; private set; }
        public bool BookAvailable { get; set; }

        public Book(string bookId, string name, string author,  string isbn, bool available)
        {
            BookId = bookId;
            BookName = name;
            BookAuthor = author;
            BookIsbn = isbn;
            BookAvailable = available;
        }

        public override string ToString()
        {
            if (BookAvailable) status = "Available";
            else status = "On Loan";

            return string.Format($"Name:\t\t{BookName}\nAuthor:\t\t{BookAuthor}\nISBN:\t\t{BookIsbn}\nBookId:\t\t{BookId}\nStatus\t\t{status}");
        }
        public string ShortInfo()
        {
            return string.Format($"Name:\t\t{BookName}\nAuthor:\t\t{BookAuthor}\nISBN:\t\t{BookIsbn}");
        }
    }
}
