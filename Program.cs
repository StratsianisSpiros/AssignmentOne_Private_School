using System;
using System.Text;

namespace PrivateSchoolTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                MainMenu.ShowMainMenu();
            }
        }
    }
}
