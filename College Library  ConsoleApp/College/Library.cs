using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    class Library
    {
        public static List<Person> LibraryUsersList = new List<Person>();
        private static List<Book> BooksList = new List<Book>();
        public static Dictionary<string, string> BorrowedBooksList = new Dictionary<string, string>();

        // Add new library user to list
        public static void AddLibraryUser(Person p)
        {
            LibraryUsersList.Add(p);
        }

        // return all library users
        public static List<Person> GetAllLibraryUsers()
        {
            return LibraryUsersList;
        }

        // Add new book to library
        public static void AddBook(Book b)
        {
            BooksList.Add(b);
        }

        // Return all books in library
        public static List<Book> GetAllBooks()
        {
            return BooksList;
        }

        // Add book to lend list
        public static void AddBookToLendList(string bookid, string userid)
        {
            BorrowedBooksList.Add(bookid,userid);
        }

        // Return list of all lended books/users
        public static Dictionary<string, string> GetAllLendedBooks()
        {
            return BorrowedBooksList;
        }


    }
}
