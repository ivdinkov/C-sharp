using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace College
{
    public abstract class Person
    {
        protected int booksBorrowed;

        public Person(string ppsn, string fname, string lname, string address, string phone, string email)
        {
            Ppsn = ppsn;
            FirstName = fname;
            LastName = lname;
            Address = address;
            Phone = phone;
            Email = email;
            booksBorrowed = 0;
        }
        
        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression("[0-9]{7}[A-Z]{1,2}$",ErrorMessage = "Invalid PPSN format !")]
        public string Ppsn { get; private set; }

        [StringLength(15, ErrorMessage = "First name exceed than 15 characres long")]
        [Required(ErrorMessage ="First name is required")]
        [RegularExpression("[A-Za-z ']+$", ErrorMessage = "Invalid character in name !")]
        public string FirstName { get; private set; }

        [StringLength(15, ErrorMessage = "Last name cannot exceed 15 characres long")]
        [Required(ErrorMessage = "Last name is required")]
        [RegularExpression("[A-Za-z ']+$", ErrorMessage = "Invalid character in name !")]
        public string LastName { get; private set; }

        [StringLength(20, ErrorMessage = "Address cannot exceed 20 characres long")]
        [Required(ErrorMessage = "{0} is required")]
        [RegularExpression("[A-Za-z0-9 ,]+$", ErrorMessage = "Invalid character in address !")]
        public string Address { get; private set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string Phone { get; private set; }

        [Required(ErrorMessage = "{0} is required")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; private set; }

        public int BorrowedBooks {
            get => booksBorrowed;
            set
            {
                if (value < 0)
                    throw new Exception("Number of books cannot be negative");
                booksBorrowed = value;
            }
        }

        public virtual void BorrowBook(string personId)
        {
            booksBorrowed++;
        }

        public virtual void ReturnBook()
        {
            if(booksBorrowed > 0)
            booksBorrowed--;
        }

        // Override ToString method. When called as ConsoleWrite(personbject) is going to print details about this object
        public override string ToString()
        {
            return string.Format(
            "\nPPSN:\t\t{0},\nName:\t\t{1} {2}\nAddress:\t{3}\nPhone:\t\t{4}\nEmail:\t\t{5}\n\n", Ppsn, FirstName, LastName, Address, Phone, Email);
        }
    }
}
