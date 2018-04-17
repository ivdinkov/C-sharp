using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace College
{
    public class College
    {

        private const int STATUSLECTURER = 1;
        private const int MAINMENUMAXCHOICE = 10;
        private const int SEARCHMENUMAXCHOICE = 4;


        // Main method
        static void Main(string[] args)
        {
            // Populate some test data
            GenerateDummieAccounts();

            // Display main menu
            DisplayMainMenu();

            Console.ReadLine();
        }

        // Display main menu
        public static void DisplayMainMenu()
        {
            int x = 0;
            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------- Main Menu ---------------------------------");
                Console.WriteLine("+\t\t\t\t\t\t\t\t\t+");
                Console.WriteLine("+\t\tSelect from the menu\t\t\t\t\t+");
                Console.WriteLine("+\t\t--------------------\t\t\t\t\t+");
                Console.WriteLine("+\t\t\t\t\t\t\t\t\t+");
                Console.WriteLine("+\t\tACCOUNTS\t\t\t\t\t\t+");
                Console.WriteLine("+\t\t(1) Add student account\t\t\t\t\t+");
                Console.WriteLine("+\t\t(2) Add lecturer account\t\t\t\t+");
                Console.WriteLine("+\t\t(3) Display all student accounts\t\t\t+");
                Console.WriteLine("+\t\t(4) Display all lecturer accounts\t\t\t+");
                Console.WriteLine("+\t\t(5) Search for lecturer/student\t\t\t\t+");
                Console.WriteLine("+\t\t\t\t\t\t\t\t\t+");
                Console.WriteLine("+\t\tBOOKS\t\t\t\t\t\t\t+");
                Console.WriteLine("+\t\t(6) List all books\t\t\t\t\t+");
                Console.WriteLine("+\t\t(7) Lend book\t\t\t\t\t\t+");
                Console.WriteLine("+\t\t(8) Return book\t\t\t\t\t\t+");
                Console.WriteLine("+\t\t(9) List books on loan\t\t\t\t\t+");
                Console.WriteLine("+\t\t\t\t\t\t\t\t\t+");
                Console.WriteLine("+\t\t(10) Quit\t\t\t\t\t\t+");
                Console.WriteLine("-------------------------------------------------------------------------");

                string a = Console.ReadLine();

                if (IsInteger(a, out x))
                    choice = x;

            } while (!Range(choice, 1, MAINMENUMAXCHOICE));
            // go to search menu
            if (choice == 5)
                DisplaySearchMenu();
            else
                ExecuteUserChoiceFromMainMenu(choice);
        }

        // Display search menu
        private static void DisplaySearchMenu()
        {
            int x;
            int choice = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("----------------------------- Search Menu -------------------------------");
                Console.WriteLine("+\t\t\t\t\t\t\t\t\t+");
                Console.WriteLine("+\t\tSelect from the menu\t\t\t\t\t+");
                Console.WriteLine("+\t\t--------------------\t\t\t\t\t+");
                Console.WriteLine("+\t\t\t\t\t\t\t\t\t+");
                Console.WriteLine("+\t\t(1) Search by ID\t\t\t\t\t+");
                Console.WriteLine("+\t\t(2) Search by Name\t\t\t\t\t+");
                Console.WriteLine("+\t\t(3) Search by PPSN\t\t\t\t\t+");
                Console.WriteLine("+\t\t\t\t\t\t\t\t\t+");
                Console.WriteLine("+\t\t(4) Main Menu\t\t\t\t\t\t+");
                Console.WriteLine("-------------------------------------------------------------------------");

                string a = Console.ReadLine();

                if (IsInteger(a, out x))
                    choice = x;

            } while (!Range(choice, 1, SEARCHMENUMAXCHOICE));

            if (choice == 4)
                DisplayMainMenu();
            else
                ExecuteUserChoiceFromSearchMenu(x);
        }

        // Validate main menu @choice 
        public static bool Range(int check, int start, int finish)
        {
            return check >= start && check <= finish;
        }

        // Execute user choice from main menu
        private static void ExecuteUserChoiceFromMainMenu(int choice)
        {
            do
            {
                switch (choice)
                {
                    case 1:
                        //Create new Student Account
                        PrepareDataForNewStudentAccount();
                        break;
                    case 2:
                        //Create new lecturer account
                        PrepareDataForNewLecturerAccount();
                        break;
                    case 3:
                        //Display all student accounts 1=student
                        DisplayAccounts(1);
                        break;
                    case 4:
                        //Display all lecturer accounts 2=lecturer
                        DisplayAccounts(2);
                        break;
                    case 5:
                        //Search for lecturer/student                        
                        DisplaySearchMenu();
                        break;
                    case 6:
                        //List all book
                        DisplayAllBooks();
                        break;
                    case 7:
                        //Lend book
                        LendBook();
                        break;
                    case 8:
                        //Return book
                        ReturnBook();
                        break;
                    case 9:
                        //Return book
                        ListBookOnLoan();
                        break;
                    case 10:
                        ExitApplication();
                        break;
                    default:
                        break;
                }
            } while (true);
        }

        // Execute user choice from search menu
        private static void ExecuteUserChoiceFromSearchMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    //Search By ID
                    SearchById();
                    break;
                case 2:
                    //Search By Name
                    SearchBytName();
                    break;
                case 3:
                    //Search By PPSN
                    SearchByPpsn();
                    break;
                case 4:
                    DisplayMainMenu();
                    break;
                default:
                    break;
            }
        }

        // Display all books
        private static void DisplayAllBooks()
        {

            foreach (var item in Library.GetAllBooks())
            {
                Console.WriteLine("\n{0}", item);
                Console.WriteLine("----------------------------------------------------");
            }
            Console.WriteLine("\nPress enter key to continue..");
            Console.ReadLine();
            DisplayMainMenu();
        }

        // Lend book
        private static void LendBook()
        {
            string personId, bid;
            personId = ReadInput("\nEnter user ID. ");
            bid = ReadInput("\nEnter book ID. ");

            if (IsIdExist(personId) && IsBookIdExist(bid))
            {
                // Check if book available
                if (!IsBookAvailable(bid))
                {
                    Console.WriteLine("Sorry this book is On Loan. ");
                    Console.WriteLine("\nPress enter key to continue..");
                    Console.ReadLine();
                    DisplayMainMenu();
                }

                // Add books to list
                Library.AddBookToLendList(bid, personId);

                // Mark this book as unavailable
                UpdateBookStatus(bid, false);

                // Update lecturer/student books on loan
                try
                {
                    UpdateUserBookCount(personId, false);
                    Console.WriteLine("\nYour can collect your book..");
                    Console.WriteLine();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("\nPress enter key to continue..");
                Console.ReadLine();
                DisplayMainMenu();
            }
            else
            {
                Console.WriteLine("Invalid ID. Do you want to try again? Y/N");
                string answer = Console.ReadLine();
                if (answer.ToLower().Equals("n"))
                {
                    DisplayMainMenu();
                }
                else
                {
                    LendBook();
                }
            }
        }

        // Return book
        private static void ReturnBook()
        {
            string bid, personId = "";

            bid = ReadInput("Enter book ID: ");

            if (IsBookIdExist(bid))
            {
                // check if item is realy on loan
                if (Library.GetAllLendedBooks().ContainsKey(bid))
                {
                    // Collect person Id to update his record, before deleting on loan record
                    foreach (var item in Library.GetAllLendedBooks())
                    {
                        if (item.Key.Equals(bid))
                        {
                            // collect user id first
                            personId = item.Value;
                        }
                    }

                    // id exist so remove record from borroedbooks where Key.Value = bid
                    for (int index = 0; index < Library.GetAllLendedBooks().Count(); index++)
                    {
                        if (Library.GetAllLendedBooks().ContainsKey(bid))
                        {
                            Library.GetAllLendedBooks().Remove(bid);
                            Console.WriteLine("\nBook return success");
                            Console.WriteLine("\nPress enter key to continue..");
                            Console.ReadLine();
                            // flag for lend/borrow true => retun , false => lend
                            UpdateUserBookCount(personId, true);
                            UpdateBookStatus(bid, true);
                            DisplayMainMenu();
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Unable to locate book!");
                    // may be 
                    //log error
                    Console.WriteLine("\nPress enter key to continue..");
                    Console.ReadLine();
                    DisplayMainMenu();

                }
            }
            else
            {
                Console.WriteLine("Invalid ID. Do you want to try again? Y/N");
                string answer = Console.ReadLine();
                if (answer.ToLower().Equals("n"))
                {
                    DisplayMainMenu();
                }
                else
                {
                    ReturnBook();
                }
            }
        }

        // List books on loan
        private static void ListBookOnLoan()
        {
            if (Library.GetAllLendedBooks().Count > 0)
            {
                foreach (var item in Library.GetAllLendedBooks())
                {
                    // Display book info
                    foreach (var book in Library.GetAllBooks())
                    {
                        if (book.BookId.Equals(item.Key))
                            Console.WriteLine($"{book.ShortInfo()}");
                    }
                    // Display user info
                    Console.WriteLine("On loan to:");
                    Console.WriteLine($"PersonID: {item.Value}");
                    Console.WriteLine("\nPress enter key to continue..");
                    Console.ReadLine();
                    DisplayMainMenu();
                }
            }
            else
            {
                Console.WriteLine("No books on loan");
                Console.WriteLine("\nPress enter key to continue..");
                Console.ReadLine();
                DisplayMainMenu();
            }
        }

        // Update user book count
        private static void UpdateUserBookCount(string personId, bool flag)
        {
            var s = Library.GetAllLibraryUsers().OfType<Student>();
            foreach (var item in s)
            {
                if (item.StudentId.Equals(personId))
                {
                    if (flag)
                        item.ReturnBook();
                    else
                        item.BorrowBook(personId);
                }
            }
            var l = Library.GetAllLibraryUsers().OfType<Lecturer>();
            foreach (var item in l)
            {
                if (item.LecturerId.Equals(personId))
                {
                    if (flag)
                        item.ReturnBook();
                    else
                        item.BorrowBook(personId);
                }
            }
        }

        // Check if book available
        private static bool IsBookAvailable(string bid)
        {
            foreach (var item in Library.GetAllBooks())
            {
                if (item.BookId.Equals(bid) && item.BookAvailable.Equals(true))
                {
                    return true;
                }
            }
            return false;
        }

        // Update book status
        private static void UpdateBookStatus(string bid, bool v)
        {
            foreach (var item in Library.GetAllBooks())
            {
                if (item.BookId.Equals(bid))
                {
                    item.BookAvailable = v;
                }
            }
        }

        // Check if ID exist in the system
        private static bool IsIdExist(string id)
        {
            var s = Library.GetAllLibraryUsers().OfType<Student>();
            foreach (var item in s)
            {
                if (item.StudentId.Equals(id))
                {
                    return true;
                }
            }
            var l = Library.GetAllLibraryUsers().OfType<Lecturer>();
            foreach (var item in l)
            {
                if (item.LecturerId.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        // check If book ID exist in the s
        private static bool IsBookIdExist(string bid)
        {
            foreach (var item in Library.GetAllBooks())
            {
                if (item.BookId.Equals(bid))
                {
                    return true;
                }
            }
            return false;
        }

        // Prepare new lecturer Account
        public static void PrepareDataForNewLecturerAccount()
        {
            // Get all properties names and types
            // and use them to collect user info
            var fieldNames = CollegeLists.LecturerFields();


            // Create new PersonData object
            PersonData lecturer = new PersonData();


            // Collect user info => tempUserInfoHolder return list<Object>
            // and
            // Save list<Object> to struct PersonData
            lecturer.SetLecturerData(TempUserInfoHolder(fieldNames, STATUSLECTURER));


            // Check if collected PPSN exist in users list and reasign new one if true
            if (IsPpsnExistInList(lecturer.Ppsn))
            {
                do
                {
                    if (ReadInput("PPSN already exist do you want to enter a new one? Y/N ").ToUpper() == "N")
                    {
                        // Answer 'N', Drop the list and go to Main menu
                        DisplayMainMenu();
                        break;
                    }
                    string newPpsn = ReadInput("Enter new PPSN... ");
                    if (!IsPpsnExistInList(newPpsn))
                    {
                        lecturer.Ppsn = newPpsn;
                        break;
                    }
                } while (true);
            }


            // Everything is clear so we can
            // Create new Lecturer Account
            CreateNewLecturerAccount(lecturer);
        }

        // Create new lecturer 
        // account with data stored in PersonData
        private static void CreateNewLecturerAccount(PersonData data)
        {

            Lecturer lecturer = new Lecturer(data.Ppsn, data.Fname, data.Lname, data.Address, data.Phone, data.Email, data.Id, data.Salary);
            // Run validation abd display errors
            ValidationContext context = new ValidationContext(lecturer, null, null);
            var result = CollegeLists.ValidationResultList();
            bool valid = Validator.TryValidateObject(lecturer, context, result, true);

            if (!valid)
            {
                foreach (ValidationResult x in result)
                {
                    Console.WriteLine(x.ErrorMessage);
                }
                Console.WriteLine("\nPlease try again. ");
                Console.WriteLine("\nPress enter key to continue..");
                Console.ReadLine();
                DisplayMainMenu();
            }
            else
            {
                AddNewAccountToList(lecturer);
                DisplayMainMenu();
            };
        }

        // Preapre new student Account
        public static void PrepareDataForNewStudentAccount()
        {
            // Get all properties names and types
            // and use them to collect user info
            var fieldNames = CollegeLists.StudentFields();


            // Create new PersonData object
            PersonData student = new PersonData();


            // Collect user info => tempUserInfoHolder return list<Object>
            // and
            // Save list<Object> to struct PersonData
            student.SetStudentData(TempUserInfoHolder(fieldNames));


            // Check if collected PPSN exist in users list nad reasign new one if true
            if (IsPpsnExistInList(student.Ppsn))
            {
                do
                {
                    if (ReadInput("PPSN already exist do you want to enter a new one? Y/N ").ToUpper() == "N")
                    {
                        // Drop the list and go to Main menu
                        DisplayMainMenu();
                        break;
                    }
                    string newPpsn = ReadInput("Enter new PPSN... ");
                    if (!IsPpsnExistInList(newPpsn))
                    {
                        student.Ppsn = newPpsn;
                        break;
                    }
                } while (true);
            }
            // Everything is clear so we can
            // Create new Lecturer Account
            CreateNewStudentAccount(student);
        }

        // Create new student 
        // account with data stored in PersonData
        private static void CreateNewStudentAccount(PersonData data)
        {
            Student student = new Student(data.Ppsn, data.Fname, data.Lname, data.Address, data.Phone, data.Email, data.Id, data.StudentStatus);
            // Run validation abd display errors
            ValidationContext context = new ValidationContext(student, null, null);
            var result = CollegeLists.ValidationResultList();
            bool valid = Validator.TryValidateObject(student, context, result, true);

            if (!valid)
            {
                foreach (ValidationResult x in result)
                {
                    Console.WriteLine(x.ErrorMessage);
                }
                Console.WriteLine("\nPlease try again. ");
                Console.WriteLine("\nPress enter key to continue..");
                Console.ReadLine();
                DisplayMainMenu();
            }
            else
            {
                AddNewAccountToList(student);
                DisplayMainMenu();
            };

        }

        // Collect and store 
        // user data in temp list
        private static List<Object> TempUserInfoHolder(Dictionary<string, string> fieldNames)
        {
            // local variable to hold the new values
            var temp = CollegeLists.TempObjectList();

            // Read student status
            int status = ReadStudentStatus();

            foreach (KeyValuePair<string, string> kvp in fieldNames)
            {
                if (kvp.Value.Contains("decimal"))
                {
                    // collect data => salary
                    temp.Add(CollectDecimalData(kvp.Key));
                }
                else if (kvp.Value.Contains("id"))
                {
                    // GENERATE data => lecturerId/studentId
                    try
                    {
                        temp.Add(GenerateID(status + 1));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    // Normal string data
                    temp.Add(ReadInput(kvp.Key));
                }
            }
            temp.Add(status);
            return temp;
        }

        // Overload
        // Collect and store user data in temp list
        private static List<Object> TempUserInfoHolder(Dictionary<string, string> fieldNames, int status)
        {
            // local variable to hold the new values
            var temp = CollegeLists.TempObjectList();


            foreach (KeyValuePair<string, string> kvp in fieldNames)
            {
                // Find what type of data we have to collect
                if (kvp.Value.Contains("integer"))
                {
                    // collect data => student status
                    temp.Add(status + 1);
                }
                else if (kvp.Value.Contains("decimal"))
                {
                    // collect data => salary
                    temp.Add(CollectDecimalData(kvp.Key));
                }
                else if (kvp.Value.Contains("id"))
                {
                    // GENERATE data => lecturerId/studentId
                    temp.Add(GenerateID(status + 1));
                }
                else
                {
                    // Normal string data
                    temp.Add(ReadInput(kvp.Key));
                }
            }
            return temp;
        }

        // Collect salary as string and convert it to decimal
        // return @salary 
        private static decimal CollectDecimalData(string question)
        {
            decimal salary;
            do
            {
                string ans = ReadInput(question);
                decimal z;
                if (IsDecimal(ans, out z))
                {
                    salary = z;
                    break;
                }
                else
                    Console.WriteLine("\nInvalid input");
            } while (true);
            return salary;
        }

        // Add new account
        // to library users list
        private static void AddNewAccountToList(Person p)
        {
            try
            {
                Library.AddLibraryUser(p);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("\nPress enter key to continue..");
                Console.ReadLine();
            }
        }

        // Check if PPSN exist in list
        public static bool IsPpsnExistInList(string str)
        {
            foreach (var userObject in Library.GetAllLibraryUsers())
            {
                if (userObject.Ppsn.Contains(str))
                {
                    return true;
                }
            }
            return false;
        }

        // Display accounts
        private static void DisplayAccounts(int type)
        {
            if (Library.GetAllLibraryUsers().Count < 1)
            {
                Console.WriteLine("No user accounts. ");
                Console.WriteLine("\nPress enter key to continue..");
                Console.ReadLine();
                DisplayMainMenu();
            }
            else
            {
                switch (type)
                {
                    case 1:
                        //Loop to extract all Students
                        var students = Library.GetAllLibraryUsers().Where(p => p.GetType() == typeof(Student));
                        foreach (var item in students)
                        {
                            Console.WriteLine("\n{0}", item);
                            Console.WriteLine("----------------------------------------------------");
                        }
                        Console.WriteLine("\nPress enter key to continue..");
                        Console.ReadLine();
                        DisplayMainMenu();
                        break;
                    case 2:
                        var lecturer = Library.GetAllLibraryUsers().Where(p => p.GetType() == typeof(Lecturer));
                        foreach (var item in lecturer)
                        {
                            Console.WriteLine("\n{0}", item);
                            Console.WriteLine("----------------------------------------------------");
                        }
                        Console.WriteLine("\nPress enter key to continue..");
                        Console.ReadLine();
                        DisplayMainMenu();
                        break;
                    default:
                        break;
                }
            }
        }

        // Search By Ppsn
        private static void SearchByPpsn()
        {
            bool found = false;
            string id;
            do
            {
                id = ReadInput("Search for PPSN or part of PPSN: ");

                var students = Library.GetAllLibraryUsers().Where(p => p.GetType() == typeof(Student));
                foreach (var item in students)
                {
                    var k = (Student)item;
                    if (k.Ppsn.Contains(id) || k.Ppsn.Contains(id))
                    {
                        Console.WriteLine("\n{0}", k);
                        found = true;
                    }
                }

                var lecturer = Library.GetAllLibraryUsers().Where(p => p.GetType() == typeof(Lecturer));
                foreach (var item in lecturer)
                {
                    var k = (Lecturer)item;
                    if (k.Ppsn.Contains(id) || k.Ppsn.Contains(id))
                    {
                        Console.WriteLine("\n{0}", k);
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine("No PPSN match in accounts.");
                if (ReadInput("Do you want to search again? Y/N").ToLower().Equals("n"))
                {
                    DisplaySearchMenu();
                    break;
                }
            } while (true);

        }

        // Search By First Name
        private static void SearchBytName()
        {
            bool found = false;
            string id;
            do
            {
                id = ReadInput("Search for Name or part of Name: ");

                var students = Library.GetAllLibraryUsers().Where(p => p.GetType() == typeof(Student));
                foreach (var item in students)
                {
                    var k = (Student)item;
                    if (k.FirstName.Contains(id) || k.LastName.Contains(id))
                    {
                        Console.WriteLine("\n{0}", k);
                        found = true;
                    }
                }

                var lecturer = Library.GetAllLibraryUsers().Where(p => p.GetType() == typeof(Lecturer));
                foreach (var item in lecturer)
                {
                    var k = (Lecturer)item;
                    if (k.FirstName.Contains(id) || k.LastName.Contains(id))
                    {
                        Console.WriteLine("\n{0}", k);
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine("No match in accounts.");
                if (ReadInput("Do you want to search again? Y/N").ToLower().Equals("n"))
                {
                    DisplaySearchMenu();
                    break;
                }
            } while (true);
        }

        // Search By Id
        private static void SearchById()
        {
            bool found = false;
            string id;
            do
            {

                Console.WriteLine("\nSearch for ID or part of ID: ");
                id = Console.ReadLine();

                var students = Library.GetAllLibraryUsers().Where(p => p.GetType() == typeof(Student));
                foreach (var item in students)
                {
                    var k = (Student)item;
                    if (k.StudentId.Contains(id))
                    {
                        Console.WriteLine("\n{0}", k);
                        Console.WriteLine("----------------------------------------------------");
                        found = true;
                    }
                }

                var lecturer = Library.GetAllLibraryUsers().Where(p => p.GetType() == typeof(Lecturer));
                foreach (var item in lecturer)
                {
                    var k = (Lecturer)item;
                    if (k.LecturerId.Contains(id))
                    {
                        Console.WriteLine("\n{0}", k);
                        Console.WriteLine("----------------------------------------------------");
                        found = true;
                    }
                }

                if (!found)
                    Console.WriteLine("No match in accounts.");
                Console.WriteLine("\nDo you want to search again? Y/N");
                string answer = Console.ReadLine();
                if (answer.ToLower().Equals("n"))
                {
                    DisplaySearchMenu();
                    break;
                }
            } while (true);
        }

        // Read student status 1-Undergrad 2-Postgrad
        private static int ReadStudentStatus()
        {
            //initialize
            int status = 0, x;
            string ans;
            do
            {
                ans = ReadInput("Select student status\n\t1 - Undergrad   2 - Postgrad: ");
                Console.WriteLine();

                if (IsInteger(ans, out x))
                    status = x;

            } while (!Range(status, 1, 2));
            return status;
        }

        // Generate Lecturer OR Student ID
        public static string GenerateID(int status)
        {
            string x = "";
            Random random = new Random();
            int randomNumber = random.Next(0, 999999);

            switch (status)
            {
                case 1:
                    x = string.Concat("11", randomNumber.ToString());
                    break;
                case 2:
                    x = string.Concat("22", randomNumber.ToString());
                    break;
                case 3:
                    x = string.Concat("33", randomNumber.ToString());
                    break;
                default:
                    throw new ArgumentOutOfRangeException("Unknown user status.");
                    break;
            }

            // if generated id exist self call to generate new one
            if (IsIdExist(x))
                GenerateID(status);

            return x;
        }

        // Create some accounts to test the application
        private static void GenerateDummieAccounts()
        {

            Lecturer l = new Lecturer("1000000AB", "James", "Butt", "6649 N Blue Gum St", "065 1326547", "jbutt@gmail.com", "11123456", 326548);
            Lecturer q = new Lecturer("1000001CD", "Josephine", "Darakjy", "4 B Blue Ridge Blvd", "066 1326456", "josephine_darakjy@darakjy.org", "11132457", 336550); ;
            Lecturer e = new Lecturer("1000002AB", "Art", "Venere", "8 W Cerritos Ave  54", "067 1326365", "art@venere.org", "11141458", 346552);

            Student o = new Student("1000008AB", "Sage", "Wieser", "5 Boston Ave  88", "073 1325819", "sage_wieser@cox.net", "22195464", 1);
            Student s = new Student("1000009CD", "Kris", "Marrier", "228 Runamuck Pl  2808", "074 1325728", "kris@gmail.com", "22204465", 1);
            Student a = new Student("1000010AB", "Minna", "Amigon", "2371 Jerrold Ave", "075 1325637", "minna_amigon@yahoo.com", "22213466", 1);

            Student k = new Student("1000016AB", "Meaghan", "Garufi", "69734 E Carrillo St", "081 1325091", "meaghan@hotmail.com", "33267472", 2);
            Student z = new Student("1000017CD", "Gladys", "Rim", "322 New Horizon Blvd", "082 1325000", "gladys.rim@rim.org", "33276473", 2);
            Student m = new Student("1000018AB", "Yuki", "Whobrey", "1 State Route 27", "083 1324909", "yuki_whobrey@aol.com", "33285474", 2);

            Library.AddLibraryUser(l);
            Library.AddLibraryUser(q);
            Library.AddLibraryUser(e);

            Library.AddLibraryUser(o);
            Library.AddLibraryUser(s);
            Library.AddLibraryUser(a);

            Library.AddLibraryUser(k);
            Library.AddLibraryUser(z);
            Library.AddLibraryUser(m);

            Book b1 = new Book("10000001", "bookName1", "author", "1111111", true);
            Book b2 = new Book("10000002", "bookName1", "author", "1111111", true);
            Book b3 = new Book("10000003", "bookName1", "author", "1111111", true);
            Book b4 = new Book("10000004", "bookName2", "author", "2222222", true);
            Book b5 = new Book("10000005", "bookName3", "author", "3333333", true);
            Book b6 = new Book("10000006", "bookName3", "author", "3333333", true);
            Book b7 = new Book("10000007", "bookName4", "author", "4444444", true);
            Book b8 = new Book("10000008", "bookName4", "author", "4444444", true);
            Book b9 = new Book("10000009", "bookName5", "author", "5555555", true);
            Book b10 = new Book("10000010", "bookName5", "author", "5555555", true);
            Book b11 = new Book("10000011", "bookName6", "author", "6666666", true);
            Book b12 = new Book("10000012", "bookName7", "author", "7777777", true);
            Book b13 = new Book("10000013", "bookName8", "author", "8888888", true);
            Book b14 = new Book("10000014", "bookName9", "author", "9999999", true);
            Book b15 = new Book("10000015", "bookName10", "author", "1212121", true);
            Book b16 = new Book("10000016", "bookName10", "author", "1212121", true);


            Library.AddBook(b1);
            Library.AddBook(b2);
            Library.AddBook(b3);
            Library.AddBook(b5);
            Library.AddBook(b6);
            Library.AddBook(b7);
            Library.AddBook(b8);
            Library.AddBook(b9);
            Library.AddBook(b10);
            Library.AddBook(b11);
            Library.AddBook(b12);
            Library.AddBook(b13);
            Library.AddBook(b14);
            Library.AddBook(b15);
            Library.AddBook(b16);


        }

        // Simple check for decimal
        public static bool IsDecimal(string ans, out decimal z)
        {
            return decimal.TryParse(ans, out z);
        }

        // Simple check for integer
        private static bool IsInteger(string a, out int x)
        {
            return int.TryParse(a, out x);
        }

        // Helper to read string inputs
        private static string ReadInput(string message)
        {
            Console.Write($"\n{message}");
            return Console.ReadLine();
        }

        // Exit Application
        private static void ExitApplication()
        {
            Environment.Exit(0);
        }


    }

    public struct PersonData
    {
        string _ppsn;
        string _fname;
        string _lname;
        string _address;
        string _phone;
        string _email;
        string _id;
        decimal _salary;
        int _studentStatus;

        public void SetLecturerData(List<Object> list)
        {
            _ppsn = list.ElementAt(0).ToString();
            _fname = list.ElementAt(1).ToString();
            _lname = list.ElementAt(2).ToString();
            _address = list.ElementAt(3).ToString();
            _phone = list.ElementAt(4).ToString();
            _email = list.ElementAt(5).ToString();
            _id = list.ElementAt(6).ToString();
            _salary = (decimal)(list.ElementAt(7));
        }

        public void SetStudentData(List<Object> list)
        {
            _ppsn = list.ElementAt(0).ToString();
            _fname = list.ElementAt(1).ToString();
            _lname = list.ElementAt(2).ToString();
            _address = list.ElementAt(3).ToString();
            _phone = list.ElementAt(4).ToString();
            _email = list.ElementAt(5).ToString();
            _id = list.ElementAt(6).ToString();
            _studentStatus = (int)list.ElementAt(7);
        }

        public string Ppsn
        {
            get => _ppsn;
            set => _ppsn = value;
        }

        public string Fname
        {
            get => _fname;
            set => _fname = value;
        }

        public string Lname
        {
            get => _lname;
            set => _lname = value;
        }

        public string Address
        {
            get => _address;
            set => _address = value;
        }

        public string Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public string Email
        {
            get => _email;
            set => _email = value;
        }

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public decimal Salary
        {
            get => _salary;
            set => _salary = value;
        }

        public int StudentStatus
        {
            get => _studentStatus;
            set => _studentStatus = value;
        }

        public override string ToString()
        {
            return string.Format("\nPPSN:\t\t{0}\nName:\t\t{1} {2}\nAddress:\t{3}\nPhone:\t\t{4}\nEmail:\t\t{5}\nID:\t\t{6}\nSalary:\t\t{7}\nStudent status:\t\t{8}", Ppsn, Fname, Lname, Address, Phone, Email, Id, Salary, StudentStatus);

            //return string.Format("\nPPSN:\t\t{0},\nName:\t\t{1} {2}\nAddress:\t{3}\nPhone:\t\t{4}\nEmail:\t\t{5}\nID:\t\t{6}\nSalary:\t\t{7}\nStudent status:\t\t{8}", Ppsn, Fname, Lname, Address, Phone, Email, Id, Salary, StudentStatus);
        }
    }
}
