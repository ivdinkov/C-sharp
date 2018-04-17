using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    public class Student : Person
    {
        enum Status { Undergrad = 1, Postgrad };
        protected string _studentId;
        public string StudentId
        {
            get => _studentId;        
            private set => _studentId = value;
        }
        public int StudentStatus { get; private set; }

        const int MAXBOOKUNDERGRAD = 5;
        const int MAXBOOKPOSTGRAD = 10;

        // Constructor Student
        public Student(string ppsn, string fname, string lname, string address, string phone, string email, string studentId, int studentStatus) : base(ppsn, fname, lname, address, phone, email)
        {
            StudentId = studentId;
            StudentStatus = studentStatus;
        }

        // Borrow book
        public override void BorrowBook(string personId)
        {
            int status = 0, bb = 0;
            var students = Library.GetAllLibraryUsers().Where(p => p.GetType() == typeof(Student));
            foreach (var item in students)
            {
                var k = (Student)item;
                if (k.StudentId.Contains(personId))
                {
                    bb = k.booksBorrowed;
                    status = k.StudentStatus;
                }
            }
            switch (status)
            {
                case 1:
                    if (bb >= MAXBOOKUNDERGRAD)
                        throw new Exception("\nYou have reached your book limit");
                    else
                        booksBorrowed++;
                    break;
                case 2:
                    if (bb >= MAXBOOKPOSTGRAD)
                        throw new Exception("\nYou have reached your book limit");
                    else
                        booksBorrowed++;
                    break;
                default:
                    break;
            }
        }

        // Return book
        public override void ReturnBook()
        {
            if (booksBorrowed > 0)
                booksBorrowed--;
        }

        // Override ToString method. When called as ConsoleWrite(studentobject) is going to print details about this object
        public override string ToString()
        {
            return string.Format(
            "Student ID:\t{6}\nPPSN:\t\t{0}\nName:\t\t{1} {2}\nAddress:\t{3}\nPhone:\t\t{4}\nEmail:\t\t{5}\nStatus:\t\t{7}\nBooks on loan: \t{8}", Ppsn, FirstName, LastName, Address, Phone, Email, StudentId, (Status)StudentStatus, BorrowedBooks);
        }
        // Short info
        public string ShortInfo()
        {
            return string.Format(
        "Student ID:\t{6}\nPPSN:\t\t{0}\nName:\t\t{1} {2}\nAddress:\t{3}\nPhone:\t\t{4}\nEmail:\t\t{5}\nStatus:\t\t{7}\nBooks on loan: \t{8}", Ppsn, FirstName, LastName, Address, Phone, Email, (Status)StudentStatus, BorrowedBooks);

        }

    }
}
