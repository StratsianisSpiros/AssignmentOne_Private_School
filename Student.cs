using System;
using System.Collections.Generic;

namespace PrivateSchoolTwo
{
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public decimal TuitionFees { get; set; }

        public string GetFullName { get => FirstName + " " + LastName; }

        //Method to compare student equality base on fullname and date of birth to avoid duplication
        public bool IsStudentSame(Student other)
        {
            if (other == null)
                return false;

            if (GetFullName != other.GetFullName || DateOfBirth != other.DateOfBirth)
                return false;

            return true;
        }

        public List<Course> Courses { get; set; } = new List<Course>();
        public List<Assignement> Assignement { get; set; } = new List<Assignement>();

        public void AddCourse(Course course) => Courses.Add(course);
        public void AddAssignement(Assignement assignement) => Assignement.Add(assignement);

        public Student() { }
        public Student(string firstName, string lastName, DateTime dateOfBirth, decimal tuitionFees)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }

        //Shows courses of current student
        public void ShowCourses()
        {
            for (int i = 0; i < Courses.Count; i++)
            {
                Console.Write(Environment.NewLine);
                FillLine(80, "-", ConsoleColor.DarkGreen);
                WriteInColor($"{i + 1}", ConsoleColor.Green);
                Console.Write(". Course ");
                WriteInColor(Courses[i].Title, ConsoleColor.Yellow);
                Console.Write(" in ");
                WriteInColor(Courses[i].Stream, ConsoleColor.Yellow);
                Console.Write(" is ");
                WriteInColor(Courses[i].Type, ConsoleColor.Yellow);
                Console.Write(" and from ");
                WriteInColor(Courses[i].StartDate.ToString("dd/MM/yyyy"), ConsoleColor.Magenta);
                Console.Write(" until ");
                WriteInColor(Courses[i].EndDate.ToString("dd/MM/yyyy"), ConsoleColor.Magenta);
            }
            Console.WriteLine(Environment.NewLine);
        }

        //Method to show assignements in current class
        public void ShowAssignements()
        {
            for (int i = 0; i < Assignement.Count; i++)
            {
                Console.Write(Environment.NewLine);
                FillLine(90, "-", ConsoleColor.DarkGreen);
                WriteInColor($"{i + 1}", ConsoleColor.Green);
                Console.Write(". Assignement ");
                WriteInColor(Assignement[i].Title, ConsoleColor.Yellow);
                Console.Write(" with description --> ");
                WriteInColor(Assignement[i].Description, ConsoleColor.Yellow);
                Console.Write(Environment.NewLine);
                Console.Write(" with oral mark -- ");
                WriteInColor(Assignement[i].OralMark.ToString(), ConsoleColor.Red);
                Console.Write(" and written mark -- ");
                WriteInColor(Assignement[i].TotalMark.ToString(), ConsoleColor.Red);
            }
            Console.WriteLine(Environment.NewLine);
        }
        //Method to fill class properties except course
        public void FillData()
        {
            Console.WriteLine("Enter Student first name. ");
            FirstName = User.InputLetters();
            Console.WriteLine("Enter Student last name. ");
            LastName = User.InputLetters();
            Console.WriteLine("Enter Student date of birth. ");
            DateOfBirth = User.InputDate(DateTime.Now.AddYears(-50), DateTime.Now.AddYears(-18));//age must be 18 and above
            Console.WriteLine("Enter Cost of tuition for student. ");
            TuitionFees = (decimal)User.InputDouble(0, 5000); //can change max value
        }

        private Action<string, ConsoleColor> WriteInColor = (s, display) => ShowData.WriteInColor(s, display);
        private Action<int, string, ConsoleColor> FillLine = (times, c, display) => ShowData.FillLine(times, c, display);
    }
}
