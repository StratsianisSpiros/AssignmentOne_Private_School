using System;

namespace PrivateSchoolTwo
{
    class Trainer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }

        public string GetFullName { get => FirstName + " " + LastName; }

        public bool IsTrainerSame(Trainer other)
        {
            if (other == null)
                return false;

            if (GetFullName != other.GetFullName)
                return false;

            return true;
        }

        public Trainer() { }
        public Trainer(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }

        //Method to fill class properties
        public void FillData()
        {
            Console.WriteLine("Enter Trainer first name. ");
            FirstName = User.InputLetters();
            Console.WriteLine("Enter Trainer last name. ");
            LastName = User.InputLetters();
            Console.Write("Enter subject : ");
            Subject = User.InputAny();
        }
    }
}
