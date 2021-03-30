using System;
using System.Collections.Generic;
using System.Linq;

namespace PrivateSchoolTwo
{
    static class MainMenu
    {
        static List<Course> Courses = new List<Course>(); //List to hold courses objects
        static List<Student> Students = new List<Student>(); //List to hold student objects
        static List<Trainer> Trainers = new List<Trainer>(); //List to hold trainers object
        static List<Assignement> Assignements = new List<Assignement>(); //List to hold assignements objects
        static readonly string schoolName = "SPIROS' PRIVATE SCHOOL";//school name

        //Displays application's main menu
        public static void ShowMainMenu()
        {
            Console.Clear();
            WriteInColor(schoolName, ConsoleColor.Yellow);
            WriteInColor("\n\n1.", ConsoleColor.Green);
            WriteInColor(" Courses\n", ConsoleColor.Cyan);
            WriteInColor("2.", ConsoleColor.Green);
            WriteInColor(" Trainers\n", ConsoleColor.Cyan);
            WriteInColor("3.", ConsoleColor.Green);
            WriteInColor(" Students\n", ConsoleColor.Cyan);
            WriteInColor("4.", ConsoleColor.Green);
            WriteInColor(" Display Data\n", ConsoleColor.Cyan);
            WriteInColor("5.", ConsoleColor.Green);
            WriteInColor(" Exit\n", ConsoleColor.Red);
            Console.Write(Environment.NewLine);
            int selection = InputMinMax(1, 5);

            switch (selection)
            {
                case 1: CoursesMenu();
                    break;
                case 2: TrainerMenu();
                    break;
                case 3: StudentMenu();
                    break;
                case 4: DisplaydataMenu();
                    break;
                case 5: Environment.Exit(0);
                    break;
                default: InvalidSelection(); 
                    ShowMainMenu();
                    break;
            }
        }

        //Dissplays application's course menu
        private static void CoursesMenu()
        {
            Console.Clear();
            WriteInColor(schoolName, ConsoleColor.Yellow);
            WriteInColor("\n\n1.", ConsoleColor.Green);
            WriteInColor(" Add Course\n", ConsoleColor.Cyan);
            WriteInColor("2.", ConsoleColor.Green);
            WriteInColor(" Add Assignement\n", ConsoleColor.Cyan);
            WriteInColor("3.", ConsoleColor.Green);
            WriteInColor(" Show Students per Course\n", ConsoleColor.Cyan);
            WriteInColor("4.", ConsoleColor.Green);
            WriteInColor(" Show Assignements due date\n", ConsoleColor.Cyan);
            WriteInColor("5.", ConsoleColor.Green);
            WriteInColor(" Display Data\n", ConsoleColor.Cyan);
            WriteInColor("6.", ConsoleColor.Green);
            WriteInColor(" Return\n", ConsoleColor.Red);
            Console.Write(Environment.NewLine);
            int selection = InputMinMax(1, 6);

            switch (selection)
            {
                case 1: AddCourses();
                    CoursesMenu();
                    break;
                case 2: AddAssignements();
                    CoursesMenu();
                    break;
                case 3:
                    ShowData.ShowStudentsPerCourse(Courses);
                    PressKeyToContinue();
                    CoursesMenu();
                    break;
                case 4:
                    ShowData.ShowAssignementDueDate(Assignements);
                    PressKeyToContinue();
                    CoursesMenu();
                    break;
                case 5: DisplaydataMenu();
                    break;
                case 6: ShowMainMenu();
                    break;
                default: InvalidSelection();
                    CoursesMenu();
                    break;
            }
        }

        //Dissplays application's student menu
        private static void StudentMenu()
        { 
            Console.Clear();
            WriteInColor(schoolName, ConsoleColor.Yellow);
            WriteInColor("\n\n1.", ConsoleColor.Green);
            WriteInColor(" Add Student\n", ConsoleColor.Cyan);
            WriteInColor("2.", ConsoleColor.Green);
            WriteInColor(" Add Assignement\n", ConsoleColor.Cyan);
            WriteInColor("3.", ConsoleColor.Green);
            WriteInColor(" Show Students per Course\n", ConsoleColor.Cyan);
            WriteInColor("4.", ConsoleColor.Green);
            WriteInColor(" Show Assignements due date\n", ConsoleColor.Cyan);
            WriteInColor("5.", ConsoleColor.Green);
            WriteInColor(" Display Data\n", ConsoleColor.Cyan);
            WriteInColor("6.", ConsoleColor.Green);
            WriteInColor(" Return\n", ConsoleColor.Red);
            Console.Write(Environment.NewLine);
            int selection = InputMinMax(1, 6);

            switch (selection)
            {
                case 1: AddStudent();
                    StudentMenu();
                    break;
                case 2: AddAssignements();
                    StudentMenu();
                    break;
                case 3:
                    ShowData.ShowStudentsPerCourse(Courses);
                    PressKeyToContinue();
                    StudentMenu();
                    break;
                case 4:
                    ShowData.ShowAssignementDueDate(Assignements);
                    PressKeyToContinue();
                    CoursesMenu();
                    break;
                case 5: DisplaydataMenu();
                    break;
                case 6: ShowMainMenu();
                    break;
                default: InvalidSelection();
                    StudentMenu();
                    break;
            }
        }
        
        //Dissplays application's trainer menu
        private static void TrainerMenu()
        {
            Console.Clear();
            WriteInColor(schoolName, ConsoleColor.Yellow);
            WriteInColor("\n\n1.", ConsoleColor.Green);
            WriteInColor(" Add Trainer\n", ConsoleColor.Cyan);
            WriteInColor("2.", ConsoleColor.Green);
            WriteInColor(" Show Trainers per Course\n", ConsoleColor.Cyan);
            WriteInColor("3.", ConsoleColor.Green);
            WriteInColor(" Display Data\n", ConsoleColor.Cyan);
            WriteInColor("4.", ConsoleColor.Green);
            WriteInColor(" Return\n", ConsoleColor.Red);
            Console.Write(Environment.NewLine);
            int selection = InputMinMax(1, 4);
            switch (selection)
            {
                case 1: AddTrainer();
                    TrainerMenu();
                    break;
                case 2:
                    ShowData.ShowTrainerPerCourse(Courses);
                    PressKeyToContinue();
                    TrainerMenu();
                    break;
                case 3: DisplaydataMenu();
                    break;
                case 4: ShowMainMenu();
                    break;
                default: 
                    InvalidSelection();
                    TrainerMenu();
                    break;
            }
        }

        //Dissplays application's display data menu
        private static void DisplaydataMenu()
        {
            Console.Clear();
            WriteInColor(schoolName, ConsoleColor.Yellow);
            WriteInColor("\n\n1.", ConsoleColor.Green);
            WriteInColor(" Show Courses\n", ConsoleColor.Cyan); //show all information on course
            WriteInColor("2.", ConsoleColor.Green);
            WriteInColor(" Show Trainers\n", ConsoleColor.Cyan); //show all info on trainers
            WriteInColor("3.", ConsoleColor.Green);
            WriteInColor(" Show Students\n", ConsoleColor.Cyan); //show all info students
            WriteInColor("4.", ConsoleColor.Green);
            WriteInColor(" Show Assignements\n", ConsoleColor.Cyan); //show all assignement info
            WriteInColor("5.", ConsoleColor.Green);
            WriteInColor(" Show Trainers per Course\n", ConsoleColor.Cyan); //show trainers per course
            WriteInColor("6.", ConsoleColor.Green);
            WriteInColor(" Show Students per Course\n", ConsoleColor.Cyan); //show students per course
            WriteInColor("7.", ConsoleColor.Green);
            WriteInColor(" Show Assignement per Course\n", ConsoleColor.Cyan); //show assignement per course
            WriteInColor("8.", ConsoleColor.Green);
            WriteInColor(" Show Assignements per Student\n", ConsoleColor.Cyan); //show assignement per student
            WriteInColor("9.", ConsoleColor.Green);
            WriteInColor(" Show Student with more than one Course\n", ConsoleColor.Cyan); //show students with more than one course
            WriteInColor("10.", ConsoleColor.Green);
            WriteInColor(" Return\n", ConsoleColor.Red);
            Console.Write(Environment.NewLine);
            int selection = InputMinMax(1, 10);

            switch (selection)
            {
                case 1: ShowData.ShowCourses(Courses);
                    PressKeyToContinue();
                    DisplaydataMenu();
                    break;
                case 2:
                    ShowData.ShowTrainers(Trainers);
                    PressKeyToContinue();
                    DisplaydataMenu();
                    break;
                case 3:
                    ShowData.ShowStudents(Students);
                    PressKeyToContinue();
                    DisplaydataMenu();
                    break;
                case 4:
                    ShowData.ShowAssignements(Assignements);
                    PressKeyToContinue();
                    DisplaydataMenu();
                    break;
                case 5:
                    ShowData.ShowTrainerPerCourse(Courses);
                    PressKeyToContinue();
                    DisplaydataMenu();
                    break;
                case 6:
                    ShowData.ShowStudentsPerCourse(Courses);
                    PressKeyToContinue();
                    DisplaydataMenu();
                    break;
                case 7:
                    ShowData.ShowAssignementPerCourse(Courses);
                    PressKeyToContinue();
                    DisplaydataMenu();
                    break;
                case 8:
                    ShowData.ShowAssignementPerStudent(Students);
                    PressKeyToContinue();
                    DisplaydataMenu();
                    break;
                case 9:
                    ShowData.ShowStudentsWithManyCourses(Students);
                    PressKeyToContinue();
                    DisplaydataMenu();
                    break;
                case 10: ShowMainMenu();
                    break;
                default: InvalidSelection();             
                         DisplaydataMenu();
                    break;
            }
        }

        ////Makes everey char of string to display in random console color
        //private static void ColorfulsString(string s)
        //{
        //    foreach (char c in s)
        //    {
        //        WriteInColor(c.ToString(), GetRandomColor());
        //    }
        //    Console.Write(Environment.NewLine);
        //}

        //Displays press key to continue in color
        private static void PressKeyToContinue()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Press any key to continue...");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(Environment.NewLine);
            Console.ReadKey(true);
        }

        //Function to warn user if invalid selection in menus
        private static void InvalidSelection()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Selection.");
            Console.ForegroundColor = ConsoleColor.White;
            PressKeyToContinue();
        }

        //Displays Entry alredy exist
        private static void EntryAlreadyExist()
        {
            WriteInColor("Entry already exist!", ConsoleColor.Red);
            Console.Write(Environment.NewLine);
        }

        //Ask user number of entries, then creates object and calls method to fill data then stores to list
        private static void AddCourses()
        {
            Console.WriteLine("How many entries would you like to make ?  ");
            int times = InputMinMax(1, 10); //wanted to limit entries doesn't make sense for user to have int.Max entries
                                                //we can change max value anytime
            for (int i = 1; i <= times; i++)
            {
                Course myCourse = new Course();
                myCourse.FillData();

                if (IfCourseExist(myCourse))
                {
                    EntryAlreadyExist();
                    PressKeyToContinue();
                }
                else
                {
                    Courses.Add(myCourse);
                    Console.Clear();
                    ShowData.ShowCourses(Courses);
                    PressKeyToContinue();
                }
            }
        }

        //Checks if course exists in list
        private static bool IfCourseExist(Course course)
        {
            foreach (Course c in Courses)
            {
                if (c.IscourseSame(course))
                    return true;
            }

            return false;
        }

        //Ask user number of entries, then creates object and calls method to fill data then stores to list
        private static void AddStudent()
        {
            Console.WriteLine("How many entries would you like to make ? ");
            int times = InputMinMax(1, 10); //wanted to limit entries doesn't make sense for user to have int.Max entries
                                            //we can change max value anytime
            for (int i = 1; i <= times; i++)
            {
                Console.Clear();
                ShowData.ShowCourses(Courses);
                Student myStudent = new Student();
                Console.WriteLine("Select the course to add the student (number). ");
                int num = InputMinMax(1, Courses.Count) - 1;
                myStudent.AddCourse(Courses[num]);
                myStudent.FillData();

                if (Courses[num].CheckStudent(myStudent))
                {
                    EntryAlreadyExist();
                    PressKeyToContinue();
                }
                else
                {
                    Students.Add(myStudent);
                    Courses[num].AddStudent(myStudent);
                    Console.Clear();
                    ShowData.ShowStudents(Students);
                    PressKeyToContinue();
                }
            }
        }

        //Ask user number of entries, then creates object and calls method to fill data then stores to list
        private static void AddAssignements()
        {
            Console.WriteLine("How many entries would you like to make ? ");
            int times = InputMinMax(1, 10); //wanted to limit entries doesn't make sense for user to have int.Max entries
                                            //we can change max value anytime
            for (int i = 1; i <= times; i++)
            {
                Console.Clear();
                ShowData.ShowCourses(Courses);
                Assignement myAssignement = new Assignement();
                Console.WriteLine("Select the course to add the assignement : ");
                int num = InputMinMax(1, Courses.Count) - 1;
                ShowData.ShowStudents(Students);
                Console.WriteLine("Select the student to add the assignement : ");
                int num1 = InputMinMax(1, Students.Count) - 1;
                myAssignement.FillData(Courses[num].StartDate, Courses[num].EndDate);

                //Checks if assignement and student exist in current course
                if (Courses[num].CheckAssignement(myAssignement) && Courses[num].CheckStudent(Students[num1]))
                {
                    EntryAlreadyExist();
                    PressKeyToContinue();
                }
                else
                {
                    Students[num1].AddAssignement(myAssignement);
                    Courses[num].AddAssignement(myAssignement);
                    myAssignement.Course = Courses[num];//We need course to access date for submisssion date
                    Assignements.Add(myAssignement);
                    Console.Clear();
                    ShowData.ShowAssignements(Assignements);
                    PressKeyToContinue();
                }
            }
        }
        //Ask user number of entries, then creates object and calls method to fill data then stores to list
        private static void AddTrainer()
        {
            Console.WriteLine("How many entries would you like to make ? ");
            int times = InputMinMax(1, 10); //wanted to limit entries doesn't make sense for user to have int.Max entries
                                            //we can change max value anytime
            for (int i = 1; i <= times; i++)
            {
                Console.Clear();
                ShowData.ShowCourses(Courses);
                Trainer myTrainer = new Trainer();
                Console.WriteLine("Select the course to add the trainer (number). ");
                int num = InputMinMax(1, Courses.Count) - 1;
                myTrainer.FillData();

                if (Courses[num].CheckTrainer(myTrainer))
                {
                    EntryAlreadyExist();
                    PressKeyToContinue();
                }
                else
                {
                    Trainers.Add(myTrainer);
                    Courses[num].AddTrainer(myTrainer);
                    Console.Clear();
                    ShowData.ShowTrainers(Trainers);
                    PressKeyToContinue();
                }
            }
        }

        static readonly Random r = new Random();

        //Method to create random data from synthetic data class
        public static void CreateData()
        {
            SyntheticData data = new SyntheticData();
            data.DataCourses(ref Courses);
            data.DataStudents(ref Students);
            data.DataTrainers(ref Trainers);
            data.DataAssignements(ref Assignements);
            List<Trainer> RandomTrainers = new List<Trainer>();
            List<Student> RandomStudents = new List<Student>();
            List<Assignement> RandomAssign = new List<Assignement>();

            //Stores random students in courses and student lists
            foreach (Course c in Courses)
            {
                int loc;

                if (!RandomStudents.Any())//Checks if randomStudent list is empty. If empty it fills from synthetic data
                {
                    data.DataStudents(ref RandomStudents);
                }

                for (int i = 0; i < 5; i++)
                {
                    loc = r.Next(0, RandomStudents.Count);//gets one random entry from randomStudents list
                    c.AddStudent(RandomStudents[loc]);//add student to course

                    //Checks if student in current class exists in student list
                    //then adds course in student class --> course list
                    for (int j = 0; j < Students.Count; j++)
                    {
                        if (RandomStudents[loc].IsStudentSame(Students[j]))
                            Students[j].AddCourse(c);
                    }

                    RandomStudents.RemoveAt(loc);//Removes student. If all removed list will be created again.
                }
            }

            //Stores random trainer at each course from synthetic data list with no duplicates
            //if trainers more than courses
            foreach (Course crs in Courses)
            {
                int loc;

                if (!RandomTrainers.Any())//Checks if randomTrainer list empty
                {
                    data.DataTrainers(ref RandomTrainers);
                }
                
                for (int i = 0; i < 2; i++)
                {                   
                    loc = r.Next(0, RandomTrainers.Count);//gets random trainer from list
                    crs.AddTrainer(RandomTrainers[loc]);//adds trainer to course
                    RandomTrainers.RemoveAt(loc);//removes trainer from randomTrainers list
                }                
            }

            //Stores random assignements for courses and students
            foreach (Course c in Courses)
            {
                for (int i = 0; i < 2; i++)
                {
                    int loc;

                    if (!RandomAssign.Any())//Checks if randomAssign list is empty
                    {
                        data.DataAssignements(ref RandomAssign);
                    }

                    loc = r.Next(0, RandomAssign.Count);//gets random assignement from list
                    c.AddAssignement(RandomAssign[loc]);//add previous assignements to current course                

                    //checks the names in student list inside current course with the student in student list
                    //student gets one assignement per course.
                    foreach (Student st in Students)
                    {
                        for (int j = 0; j < c.Students.Count; j++)
                        {
                            if (st.IsStudentSame(c.Students[j]))
                            {
                                st.AddAssignement(RandomAssign[loc]);
                                c.Students[j].AddAssignement(RandomAssign[loc]);
                                break;
                            }                            
                        }
                    }

                    //Add course last so the student in assignements will be updated
                    foreach (Assignement asgn in Assignements)
                    {
                        if (asgn.IsAssignementSame(RandomAssign[loc]))//Check if random asignement is assignement then add course
                            asgn.Course = c;
                    }

                    RandomAssign.RemoveAt(loc);//removes assignement from randomAssign. no duplicate assignements
                }
            }
        }

        private static Action<string, ConsoleColor> WriteInColor = (s, display) => ShowData.WriteInColor(s, display);
        private static Func<int, int, int> InputMinMax = (min, max) => User.InputMinMax(min, max);
        //private static Func<ConsoleColor> GetRandomColor = () => ShowData.GetRandomColor();
    }
}
