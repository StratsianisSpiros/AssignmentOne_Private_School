using System;
using System.Text.RegularExpressions;
using System.Globalization;

namespace PrivateSchoolTwo
{
    static class User
    {
        static readonly CultureInfo Greek = new CultureInfo("el-GR"); //Changes culture to greek
        //Just a console readline, wanted to use method to change input color and for consistency of names
        //i didn't alter in fill method (could use directly InputChangeColor method which i have here private)
        public static string InputAny()
        {
            string temp = "";
            InputChangeColor(ref temp, ConsoleColor.Magenta);
            return temp;
        }

        //Accepts date from user in a dd-MM-yyyy format
        public static DateTime InputDate(DateTime min, DateTime max)
        {
            string temp = "";

            //Array to accepts dates in these formats
            string[] dateFormats = new string[] { "dd-MM-yyyy" , "dd/MM/yyyy" , "dd.MM.yyyy",
                                                  "d-M-yyyy", "d/M/yyyy", "d.M.yyyy"};

            do
            {
                WriteInColor("Enter date in format ", ConsoleColor.Green);
                WriteInColor("(dd-MM-yyyy, dd/MM/yyy, dd.MM.yyyy)", ConsoleColor.Red);
                WriteInColor(" from ", ConsoleColor.Green);
                WriteInColor(min.ToString("dd/MM/yyyy"), ConsoleColor.Cyan);
                WriteInColor(" to ", ConsoleColor.Green);
                WriteInColor(max.ToString("dd/MM/yyyy"), ConsoleColor.Cyan);
                WriteInColor(", or type exit : ", ConsoleColor.Green);
                InputChangeColor(ref temp, ConsoleColor.Magenta);
                ExitInput(temp);
            }
            while (!(DateTime.TryParseExact(temp, dateFormats, Greek, DateTimeStyles.None, out _) 
                    && DateTime.ParseExact(temp, dateFormats, Greek, DateTimeStyles.None) >= min 
                    && DateTime.ParseExact(temp, dateFormats, Greek, DateTimeStyles.None) <= max));

            return DateTime.ParseExact(temp, dateFormats, Greek, DateTimeStyles.None);
        }

        //User input for double values, will use it for tuition fees input from user then cast to decimal
        //I dont want user to enter values with comma and check with IfComma
        public static double InputDouble(int min, int max)
        {
            string temp = "";
            do
            {
                WriteInColor("Enter value from ", ConsoleColor.Green);
                WriteInColor(min.ToString(), ConsoleColor.Cyan);
                WriteInColor(" to ", ConsoleColor.Green);
                WriteInColor(max.ToString(), ConsoleColor.Cyan);
                WriteInColor(", or type exit : ", ConsoleColor.Green);
                InputChangeColor(ref temp, ConsoleColor.Magenta);
                ExitInput(temp);
            }
            while (IfComma(temp) || !double.TryParse(temp, out _) || double.Parse(temp) < min || double.Parse(temp) > max);

            return double.Parse(temp);
        }

        //Integer user input for menu
        //public static int InputMenu()
        //{
        //    string temp = "";
        //    do
        //    {
        //        InputChangeColor(ref temp);
        //    }
        //    while (!int.TryParse(temp, out int u) || int.Parse(temp) < 1);

        //    return int.Parse(temp);
        //}

        //Integer user input for menu with min and max values
        public static int InputMinMax(int min, int max)
        {
            string temp = "";
            do
            {
                WriteInColor($"Enter value from {min} to {max} : ",ConsoleColor.Green);
                InputChangeColor(ref temp, ConsoleColor.Magenta);
            }
            while (!int.TryParse(temp, out _) || int.Parse(temp) < min || int.Parse(temp) > max);

            return int.Parse(temp);
        }

        //Accepts only letters (a-zA-Z) from user and returns string
        public static string InputLetters()
        {
            bool isValid;
            string temp = "";
            do
            {
                WriteInColor("First letter of name must be capital, or type exit : ", ConsoleColor.Green);
                InputChangeColor(ref temp, ConsoleColor.Magenta);
                ExitInput(temp);
                isValid = Regex.Match(temp, @"^[A-Z][a-z]+$").Success;
            }
            while (!isValid);

            return temp;
        }

        //Gets string with first name and last name of the user 
        //public static void InputFullName(ref string firstname, ref string lastname)
        //{
        //    bool isValid;
        //    string temp;
        //    do
        //    {
        //        Console.Clear();
        //        temp = Console.ReadLine().Trim();
        //        isValid = Regex.Match(temp, @"^[a-zA-Z]+\s[a-zA-Z]+$").Success;
        //    }
        //    while (!isValid);

        //    string[] splitname = temp.Split(' ').ToArray();
        //    firstname = splitname[0];
        //    lastname = splitname[1];
        //}

        //Method to get input 1 or 2 from user to assign Full-time or Part-time type course
        //public static string InputCourseType()
        //{
        //    string temp = "";
        //    do
        //    {
        //        InputChangeColor(ref temp);
        //    }
        //    while (!int.TryParse(temp, out int k) || int.Parse(temp) < 1 || int.Parse(temp) > 2);

        //    return (int.Parse(temp) == 1) ? "Full-time" : "Part-time";
        //}

        //Checks if comma exists in given string
        private static bool IfComma(string s) => s.IndexOf(',') >= 0;

        //Changes console color on user input
        private static void InputChangeColor(ref string s, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            s = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void ExitInput(string temp)
        {
            if (temp.ToLower().Equals("exit"))
                MainMenu.ShowMainMenu();            
        }
        
        private static Action<string, ConsoleColor> WriteInColor = (s, display) => ShowData.WriteInColor(s, display);
        private static Func<ConsoleColor> GetRandomColor = () => ShowData.GetRandomColor();
    }
}
