using System;

namespace PrivateSchoolTwo
{
    class Assignement
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        public double OralMark { get; set; }
        public double TotalMark { get; set; }

        private string GetClassString { get => (Title + Description).ToLower(); }

        public Course Course { get; set; }//we need a course to assignement class so we can ger start date and end date

        //Method to check assignement date submission
        public void ShowAssignementDue(int x, DateTime date)
        {
            for (int i = 0; i < Course.Students.Count; i++)
            {
                Console.Write("Assignement ");
                WriteInColor(Title, ConsoleColor.Cyan);
                Console.Write(" for student ");
                WriteInColor(Course.Students[i].GetFullName, ConsoleColor.Cyan);
                //Lines to test if we get the desired range
                //Console.Write(" is due on ");
                //WriteInColor(SubDateTime.ToString("dd/MM/yyyy"), ConsoleColor.Blue);
                Console.WriteLine(" must be submitted from ");
                WriteInColor(date.AddDays(1 - x).ToString("dd/MM/yyyy"), ConsoleColor.Yellow);
                Console.Write(" to ");
                WriteInColor(date.AddDays(5 - x).ToString("dd/MM/yyyy"), ConsoleColor.Red);
                Console.Write(Environment.NewLine);
                FillLine(80, "-", ConsoleColor.DarkGreen);
            }
        }

        //Method to compare student equality base on fullname and date of birth to avoid duplication
        public bool IsAssignementSame(Assignement assignement)
        {
            if (assignement == null)
                return false;

            if (GetClassString != assignement.GetClassString || SubDateTime != assignement.SubDateTime)
                return false;

            return true;
        }

        public Assignement() { }
        public Assignement(string title, string description,
            DateTime subDateTime, double oralMark, double totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }

        //Method to fill class properties, need course startDate and endDate
        //When we fill data course is not yet added
        public void FillData(DateTime startDate, DateTime endDate)
        {
            Console.Write("Enter Assignement title : ");
            Title = User.InputAny();
            Console.Write("Enter Assignement description : ");
            Description = User.InputAny();
            Console.WriteLine("Enter Assignement due date. ");
            SubDateTime = User.InputDate(startDate, endDate);//Date of submission within course start-end date
            Console.WriteLine("Enter Assignement oral mark. "); //We can use any max with the user inputDouble method
            OralMark = User.InputDouble(0, 20);
            Console.WriteLine("Enter Assignement total mark. "); //We can use any max with the user inputDouble method
            TotalMark = User.InputDouble(0, 80);
        }

        private Action<string, ConsoleColor> WriteInColor = (s, display) => ShowData.WriteInColor(s, display);
        private Action<int, string, ConsoleColor> FillLine = (times, c, display) => ShowData.FillLine(times, c, display);
    }
}
