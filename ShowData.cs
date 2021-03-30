using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PrivateSchoolTwo
{
    static class ShowData
    {
        static readonly CultureInfo Greek = new CultureInfo("el-GR"); //Changes culture to greek

        public static void ShowCourses(List<Course> lst)
        {
            if (!lst.Any())
            {
                MainMenu.CreateData();
            }

            FillLine(90, "*", ConsoleColor.DarkGreen);

            foreach (Course crs in lst)
            {
                WriteInColor($"{lst.IndexOf(crs) + 1}", ConsoleColor.Green);
                Console.Write(". Course ");
                WriteInColor(crs.Title, ConsoleColor.Cyan);
                Console.Write(" in ");
                WriteInColor(crs.Stream, ConsoleColor.Cyan);
                Console.Write(" is ");
                WriteInColor(crs.Type, ConsoleColor.Cyan);
                Console.Write(" and from ");
                WriteInColor(crs.StartDate.ToString("dd/MM/yyyy"), ConsoleColor.Yellow);
                Console.Write(" until ");
                WriteInColor(crs.EndDate.ToString("dd/MM/yyyy"), ConsoleColor.Yellow);
                Console.Write(Environment.NewLine);
                FillLine(90, "-", ConsoleColor.DarkGreen);
            }
        }
        public static void ShowStudents(List<Student> lst)
        {
            if (!lst.Any())
            {
                MainMenu.CreateData();
            }

            FillLine(90, "*", ConsoleColor.DarkGreen);

            foreach (Student st in lst)
            {
                WriteInColor($"{lst.IndexOf(st) + 1}", ConsoleColor.Green);
                Console.Write(". Tuition fees for student ");
                WriteInColor(st.GetFullName, ConsoleColor.Cyan);
                Console.Write(" born in ");
                WriteInColor(st.DateOfBirth.ToString("dd/MM/yyyy"), ConsoleColor.Yellow);
                Console.Write(" are ");
                WriteInColor(st.TuitionFees.ToString("c", Greek), ConsoleColor.Red);
                Console.Write(Environment.NewLine);
                FillLine(90, "-", ConsoleColor.DarkGreen);
            }
        }
        public static void ShowTrainers(List<Trainer> lst)
        {
            if (!lst.Any())
            {
                MainMenu.CreateData();
            }

            int count = 1;
            FillLine(70, "*", ConsoleColor.DarkGreen);

            foreach (Trainer tr in lst)
            {
                WriteInColor($"{count}", ConsoleColor.Green);
                Console.Write(". Trainers' ");
                WriteInColor(tr.GetFullName, ConsoleColor.Cyan);
                Console.Write(" subject is ");
                WriteInColor(tr.Subject, ConsoleColor.Cyan);
                Console.Write(Environment.NewLine);
                FillLine(70, "-", ConsoleColor.DarkGreen);
                count++;

            }
        }
        public static void ShowAssignements(List<Assignement> lst)
        {
            if (!lst.Any())
            {
                MainMenu.CreateData();
            }

                FillLine(100, "*", ConsoleColor.DarkGreen);

            for (int i = 0; i < lst.Count; i++)
            {
                WriteInColor($"{i + 1}", ConsoleColor.Green);
                Console.Write(". Assignement ");
                WriteInColor(lst[i].Title, ConsoleColor.Cyan);
                Console.Write(", with subject ");
                WriteInColor(lst[i].Description, ConsoleColor.Cyan);
                Console.Write(", with subject ");
                WriteInColor(lst[i].SubDateTime.ToString("dd/MM/yyyy"), ConsoleColor.Red);
                Console.Write(Environment.NewLine);
                FillLine(100, "-", ConsoleColor.DarkGreen);
            }
            Console.Write(Environment.NewLine);
            
        }
        public static void ShowStudentsPerCourse(List<Course> lst)
        {
            if (!lst.Any())
            {
                MainMenu.CreateData();
            }

            foreach (Course crs in lst)
            {
                FillLine(60, "*", ConsoleColor.DarkGreen);
                Console.Write("Course ");
                WriteInColor(crs.Title, ConsoleColor.Cyan);
                Console.Write(" -- ");
                WriteInColor(crs.Stream, ConsoleColor.Cyan);
                Console.Write(" -- ");
                WriteInColor(crs.Type, ConsoleColor.Cyan);
                Console.Write(" has the students");
                crs.Showstudents();
                Console.WriteLine(Environment.NewLine);
            }
        }
        public static void ShowTrainerPerCourse(List<Course> lst)
        {
            if (!lst.Any())
            {
                MainMenu.CreateData();
            }

            foreach (Course crs in lst)
            {
                FillLine(60, "*", ConsoleColor.DarkGreen);
                Console.Write("Course ");
                WriteInColor(crs.Title, ConsoleColor.Cyan);
                Console.Write(" -- ");
                WriteInColor(crs.Stream, ConsoleColor.Cyan);
                Console.Write(" -- ");
                WriteInColor(crs.Type, ConsoleColor.Cyan);
                Console.Write(" has the trainers");
                crs.ShowTrainers();
                Console.WriteLine(Environment.NewLine);
            }
        }
        public static void ShowAssignementPerCourse(List<Course> lst)
        {
            if (!lst.Any())
            {
                MainMenu.CreateData();
            }

            foreach (Course crs in lst)
            {
                FillLine(90, "*", ConsoleColor.DarkGreen);
                Console.Write("Course ");
                WriteInColor(crs.Title, ConsoleColor.Cyan);
                Console.Write(" -- ");
                WriteInColor(crs.Stream, ConsoleColor.Cyan);
                Console.Write(" -- ");
                WriteInColor(crs.Type, ConsoleColor.Cyan);
                Console.Write(" has the assignements ");
                crs.ShowAssignements();
            }
        }
        public static void ShowAssignementPerStudent(List<Student> lst)
        {
            if (!lst.Any())
            {
                MainMenu.CreateData();
            }

            foreach (Student st in lst)
            {
                FillLine(90, "*", ConsoleColor.DarkGreen);

                if (st.Assignement.Any())
                {
                    Console.Write("Student ");
                    WriteInColor(st.GetFullName, ConsoleColor.Cyan);
                    Console.Write(" assignements are ");
                    st.ShowAssignements();
                }
            }
        }
        public static void ShowStudentsWithManyCourses(List<Student> lst)
        {
            if (!lst.Any())
            {
                MainMenu.CreateData();
            }

            foreach (Student st in lst)
            {
                if (st.Courses.Count > 1)
                {
                    FillLine(80, "*", ConsoleColor.DarkGreen);
                    Console.Write("Student ");
                    WriteInColor(st.GetFullName, ConsoleColor.Cyan);
                    Console.Write(" courses are ");
                    st.ShowCourses();
                }
            }
        }
        public static void ShowAssignementDueDate(List<Assignement> lst)
        {
            if (!lst.Any())
            {
                MainMenu.CreateData();
            }
            
            //We get the date from user and cast day of week to get the integer of day
            Console.WriteLine("Enter a date to show the assignements submissions on that week.");
            DateTime date = User.InputDate(DateTime.Now, DateTime.Now.AddYears(1));
            int x = (int)date.DayOfWeek;
            bool dateFound = false;
            FillLine(80, "*", ConsoleColor.DarkGreen);

            foreach (Assignement asgn in lst)
            {
                //Check assignement list if subDateTime is within calendat week of user input
                if (asgn.SubDateTime >= date.AddDays(-x) && asgn.SubDateTime <= date.AddDays(6 - x))
                {
                    asgn.ShowAssignementDue(x, date);
                    dateFound = true;
                }
            }

            if (!dateFound)
            {
                Console.Write("No assignement to be submitted from ", ConsoleColor.Red);
                WriteInColor(date.AddDays(1 - x).ToString("dd/MM/yyyy"), ConsoleColor.Yellow);
                Console.Write(" to ", ConsoleColor.Red);
                WriteInColor(date.AddDays(5 - x).ToString("dd/MM/yyyy"), ConsoleColor.Yellow);
                Console.WriteLine(Environment.NewLine);
            }
        }

        //Changes display color for given string
        public static void WriteInColor(string s, ConsoleColor display)
        {
            Console.ForegroundColor = display;
            Console.Write(s);
            Console.ForegroundColor = ConsoleColor.White;
        }

        //Get random color from 10 to 16 (no dark colors on display)
        static readonly Random random = new Random();
        public static ConsoleColor GetRandomColor()
        {
            ConsoleColor color = (ConsoleColor)random.Next(10, 16);
            return color;
        }

        public static void FillLine(int times, string c, ConsoleColor display)
        {
            string temp = "";
            Console.ForegroundColor = display;
            for (int i = 1; i < times; i++)
            {
                temp += c;
            }
            Console.Write(temp);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Environment.NewLine);
        }     
    }
}
