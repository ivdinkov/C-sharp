using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College
{
    class CollegeLists
    {
        public static List<ValidationResult> ValidationResultList()
        {
            return new List<ValidationResult>();
        }

        public static List<Object> TempObjectList()
        {
            return new List<Object>();
        }

        public static Dictionary<string, string> LecturerFields()
        {
            Dictionary<string, string> p = new Dictionary<string, string>();
            p.Add("PPSN (format 1234567A or 1234567AA ): ", "string");
            p.Add("First name: ", "string");
            p.Add("Last name: ", "string");
            p.Add("Address: ", "string");
            p.Add("Mobile phone (format 012 3456789 ): ", "string");
            p.Add("Email: ", "string");
            p.Add("LecturerId: ", "id");
            p.Add("Salary: ", "decimal");
            return p;
        }

        public static Dictionary<string, string> StudentFields()
        {
            Dictionary<string, string> p = new Dictionary<string, string>();
            p.Add("PPSN (format 1234567A or 1234567AA ):", "string");
            p.Add("First name: ", "string");
            p.Add("Last name: ", "string");
            p.Add("Address: ", "string");
            p.Add("Mobile phone (format 012 3456789 )", "string");
            p.Add("Email: ", "string");
            p.Add("StudentId: ", "id");
            return p;
        }
    }
}
