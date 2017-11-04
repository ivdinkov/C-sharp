using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace College
{
    public class Lecturer : Person
    {
        // Constructor for new Lecturer account
        public Lecturer(string ppsn, string fname, string lname, string address, string phone, string email, string lecturerId, decimal salary) : base(ppsn, fname, lname, address, phone, email)
        {
            LecturerId = lecturerId;
            Salary = salary;
        }

        // Auto property Salary
        [Required(ErrorMessage = "{0} is required")]
        [Range(1, 999999.99, ErrorMessage = "Invalid input for salary !")]
        public decimal Salary { get; private set; }

        // Auto property lecturerId
        public string LecturerId { get; private set; }

        // Override ToString method. When called as ConsoleWrite(lecturerobject) is going to print details about this object
        public override string ToString()
        {
            return string.Format(
            "Lecturer ID:\t{6}\nPPSN:\t\t{0}\nName:\t\t{1} {2}\nAddress:\t{3}\nPhone:\t\t{4}\nEmail:\t\t{5}\nSalary:\t\t{7}\nBooks on loan:\t{8}", Ppsn, FirstName, LastName, Address, Phone, Email, LecturerId, Salary, BorrowedBooks);
        }
        public string ShortInfo()
        {
            return string.Format(
        "Lecturer ID:\t{6}\nPPSN:\t\t{0}\nName:\t\t{1} {2}\nAddress:\t{3}\nPhone:\t\t{4}\nEmail:\t\t{5}\nBooks on loan: \t{8}", Ppsn, FirstName, LastName, Address, Phone, Email, BorrowedBooks);

        }

    }
}
