using System;
using System.Collections.Generic;

namespace PrivateSchoolTwo
{
    class Course 
    {
        public string Title { get; set; }
        public string Stream { get; private set; }

        public string Type { get; private set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string SetType(int typ) => (typ == 1) ? Type = "Full-time" : Type = "Part-time";
        public string SetStream(int value)
        {
            string temp;
            switch (value)
            {
                case 1: temp = "Python";
                     break;
                case 2: temp = "C#";
                    break;
                case 3: temp = "Java";
                    break;
                case 4: temp = "Javascript";
                    break;
                case 5: temp = "Ruby";
                    break;
                default: temp = "C#";
                    break;
            }
            return Stream = temp;
        }

        private string GetClassString { get => (Title + Stream + Type).ToLower(); }

        public List<Student> Students { get; set; } = new List<Student>();
        public List<Trainer> Trainers { get; set; } = new List<Trainer>();
        public List<Assignement> Assignements { get; set; } = new List<Assignement>();

        public void AddStudent(Student student) => Students.Add(student);
        public void AddTrainer(Trainer trainer) => Trainers.Add(trainer);
        public void AddAssignement(Assignement assignement) => Assignements.Add(assignement);

        //Check course equality based on fields
        public bool IscourseSame(Course other)
        {
            if (other == null)
                return false;

            if (GetClassString != other.GetClassString ||
                StartDate != other.StartDate || EndDate != other.EndDate)
                return false;

            return true;
        }

        //Checks if a given student exists in student list
        public bool CheckStudent(Student student)
        {
            for (int i = 0; i < Students.Count; i++)
            {
                if (Students[i].IsStudentSame(student))
                    return true;
            }

            return false;
        }

        //Checks if a given trainer exists in student list
        public bool CheckTrainer(Trainer trainer)
        {
            for (int i = 0; i < Trainers.Count; i++)
            {
                if (Trainers[i].IsTrainerSame(trainer))
                    return true;
            }

            return false;
        }

        //Checks if a given assignement exist in assignement list
        public bool CheckAssignement(Assignement assignement)
        {
            for (int i = 0; i < Assignements.Count; i++)
            {
                if (Assignements[i].IsAssignementSame(assignement))
                    return true;
            }

            return false;
        }
        //Method to show assignements in current course
        public void ShowAssignements()
        {
            for (int i = 0; i < Assignements.Count; i++)
            {
                Console.Write(Environment.NewLine);
                FillLine(90, "-", ConsoleColor.DarkGreen);
                WriteInColor($"{i + 1}", ConsoleColor.Green);
                Console.Write(". The assignement ");
                WriteInColor(Assignements[i].Title, ConsoleColor.Yellow);
                Console.Write(" with description --> ");
                WriteInColor(Assignements[i].Description, ConsoleColor.Yellow);
            }
            Console.WriteLine(Environment.NewLine);
        }

        public void Showstudents()
        {
            for (int i = 0; i < Students.Count; i++)
            {
                Console.Write(Environment.NewLine);
                FillLine(60, "-", ConsoleColor.DarkGreen);
                WriteInColor($"{i + 1}.", ConsoleColor.Green);
                WriteInColor(Students[i].GetFullName, ConsoleColor.Yellow);
            }
        }

        public void ShowTrainers()
        {
            for (int i = 0; i < Trainers.Count; i++)
            {
                Console.Write(Environment.NewLine);
                FillLine(60, "-", ConsoleColor.DarkGreen);
                WriteInColor($"{i + 1}.", ConsoleColor.Green);
                WriteInColor(Trainers[i].GetFullName, ConsoleColor.Yellow);
            }
        }

        public Course() { }
        public Course(string title, int stream, int type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            SetStream(stream);
            SetType(type);
            StartDate = startDate;
            EndDate = endDate;
        }

        //Method to fill class properties
        public void FillData()
        {
            Console.Write("Enter Course title : ");
            Title = User.InputAny();
            Console.WriteLine("Enter Course stream ");
            ShowStream();
            SetStream(User.InputMinMax(1, 5));
            Console.WriteLine("Type 1 if course is full-time or 2 for part-time.");
            SetType(User.InputMinMax(1, 2));
            Console.WriteLine("Enter Course START date. ");
            StartDate = User.InputDate(DateTime.Now, DateTime.Now.AddMonths(9));
            Console.WriteLine("Enter Course ENDd date. ");
            EndDate = User.InputDate(StartDate, StartDate.AddMonths(9));//Course end date 9 months(or anything) after start date
        }

        //Method to how stream on user to select
        private void ShowStream()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("1. Python");
            Console.WriteLine("2. C#");
            Console.WriteLine("3. Java");
            Console.WriteLine("4. Javascript");
            Console.WriteLine("5. Ruby");
            Console.ForegroundColor = ConsoleColor.White;
        }

        private Action<string, ConsoleColor> WriteInColor = (s, display) => ShowData.WriteInColor(s, display);
        private Action<int, string, ConsoleColor> FillLine = (times, c, display) => ShowData.FillLine(times, c, display);
    }
}
