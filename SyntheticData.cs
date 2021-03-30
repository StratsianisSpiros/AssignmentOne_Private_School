using System;
using System.Collections.Generic;

namespace PrivateSchoolTwo
{
    class SyntheticData
    {
        public void DataCourses(ref List<Course> lst)
        {
            lst.Add(new Course("CB8", 2, 1, new DateTime(2020, 10, 1), new DateTime(2021, 4, 1)));
            lst.Add(new Course("CB8", 3, 2, new DateTime(2020, 10, 1), new DateTime(2021, 4, 1)));
            lst.Add(new Course("CB8", 4, 2, new DateTime(2020, 10, 1), new DateTime(2021, 4, 1)));
            lst.Add(new Course("CB8", 1, 1, new DateTime(2020, 10, 1), new DateTime(2021, 4, 1)));
            lst.Add(new Course("CB12", 5, 1, new DateTime(2020, 12, 12), new DateTime(2021, 3, 12)));
            lst.Add(new Course("CB12", 3, 2, new DateTime(2020, 11, 12), new DateTime(2021, 3, 12)));
            lst.Add(new Course("CB14", 2, 1, new DateTime(2020, 10, 10), new DateTime(2021, 4, 10)));
            lst.Add(new Course("CB14", 5, 2, new DateTime(2020, 10, 10), new DateTime(2021, 4, 10)));
            lst.Add(new Course("CB18", 1, 1, new DateTime(2020, 11, 12), new DateTime(2021, 3, 12)));
            lst.Add(new Course("CB18", 3, 1, new DateTime(2020, 11, 12), new DateTime(2021, 3, 12)));
        }
        public void DataStudents(ref List<Student> lst) 
        {
            lst.Add(new Student("Kostas", "Papadopoulos", new DateTime(1980, 2, 18), 2000m));
            lst.Add(new Student("George", "Oikonomou", new DateTime(1983, 3, 19), 2000m));
            lst.Add(new Student("Niki", "Karagiani", new DateTime(1981, 4, 25), 2000m));
            lst.Add(new Student("Vassilis", "Papageorgiou", new DateTime(1978, 12, 8), 2000m));
            lst.Add(new Student("Nikolaos", "Makris", new DateTime(1980, 2, 23), 2000m));
            lst.Add(new Student("Giannis", "Chatzis", new DateTime(1984, 5, 19), 2000m));
            lst.Add(new Student("Katerina", "Lagou", new DateTime(1982, 7, 7), 2000m));
            lst.Add(new Student("Kostas", "Samaras", new DateTime(1986, 7, 27), 2000m));
            lst.Add(new Student("Vaggelis", "Marinakis", new DateTime(1983, 5, 30), 2500m));
            lst.Add(new Student("Giannis", "Pontikis", new DateTime(1976, 9, 12), 2500m));
            lst.Add(new Student("Maria", "Patera", new DateTime(1975, 12, 9), 2500m));
            lst.Add(new Student("Eirni", "Petridi", new DateTime(1979, 10, 4), 2500m));
            lst.Add(new Student("Nikolaos", "Vasilopoulos", new DateTime(1990, 3, 3), 2500m));
            lst.Add(new Student("Vasilis", "Pappas", new DateTime(1991, 11, 5), 1800m));
            lst.Add(new Student("George", "Kasidiaris", new DateTime(1993, 6, 8), 1800m));
            lst.Add(new Student("Giannis", "Anagnostopoulos", new DateTime(1982, 5, 20), 1800m));
            lst.Add(new Student("Kostas", "Efthimiadis", new DateTime(1987, 7, 24), 1800m));
            lst.Add(new Student("Maria", "Vlachou", new DateTime(1990, 9, 10), 1800m));
            lst.Add(new Student("Spiros", "Dimopoulos", new DateTime(1989, 12, 8), 2700m));
            lst.Add(new Student("Katerina", "Agorastou", new DateTime(1984, 5, 23), 2700m));
            lst.Add(new Student("Giannis", "Agravanis", new DateTime(1985, 11, 7), 2700m));
            lst.Add(new Student("Kostas", "Alexandris", new DateTime(1991, 10, 29), 2700m));
            lst.Add(new Student("George", "Antoniou", new DateTime(1993, 8, 23), 2700m));
            lst.Add(new Student("Nikolaos", "Arniakos", new DateTime(1995, 6, 16), 2700m));
            lst.Add(new Student("Maria", "Douka", new DateTime(1986, 2, 19), 3000m));
            lst.Add(new Student("Kostas", "Vergas", new DateTime(1984, 3, 25), 3000m));
            lst.Add(new Student("George", "Kallimanis", new DateTime(1975, 1, 18), 3000m));
            lst.Add(new Student("Giannis", "Koumparakis", new DateTime(1979, 8, 9), 3000m));
            lst.Add(new Student("Kostas", "Lianos", new DateTime(1976, 1, 13), 3000m));
            lst.Add(new Student("Nikolaos", "Boudouris", new DateTime(1983, 9, 7), 3000m));
        }
        public void DataTrainers(ref List<Trainer> lst)
        {
            lst.Add(new Trainer("Peter", "Parker", "Java"));
            lst.Add(new Trainer("Tony", "Stark", "C#"));
            lst.Add(new Trainer("Steve", "Rogers", "HTML"));
            lst.Add(new Trainer("Bruce", "Banner", "JavaScript"));
            lst.Add(new Trainer("Scott", "Lang", "Java"));
            lst.Add(new Trainer("Henry", "Mccoy", "C#"));
            lst.Add(new Trainer("Carol", "Danvers", "HTML"));
            lst.Add(new Trainer("Matt", "Murdock", "JavaScript"));
            lst.Add(new Trainer("Otto", "Octavius", "CSS"));
            lst.Add(new Trainer("Stephen", "Strange", "CSS"));
        }
        public void DataAssignements(ref List<Assignement> lst)
        {
            lst.Add(new Assignement("Exceptions", "Methods to handle exception", new DateTime(2021, 2, 1), 13, 70));
            lst.Add(new Assignement("Delegates", "Excercise to use delegates", new DateTime(2021, 1, 12), 15, 67));
            lst.Add(new Assignement("Classes", "Create classes and use objects", new DateTime(2020, 9, 11), 12, 89));
            lst.Add(new Assignement("Calculator", "Create simple calculator", new DateTime(2020, 11, 23), 10, 49));
            lst.Add(new Assignement("Loops", "Create methods with loops", new DateTime(2021, 3, 4), 11, 55));
            lst.Add(new Assignement("Lists", "Display data from list", new DateTime(2020, 12, 11), 17, 87));
            lst.Add(new Assignement("If statemens", "Uses of if statements", new DateTime(2021, 1, 10), 16, 34));
            lst.Add(new Assignement("Inheritance", "Create classes with inheritance", new DateTime(2021, 2, 21), 11, 65));
            lst.Add(new Assignement("Lambda Expressions", "Types of lambda expressions", new DateTime(2021, 3, 5), 12, 78));
            lst.Add(new Assignement("Arrays", "Array methods and uses", new DateTime(2020, 10, 23), 15, 91));
        }

        readonly Random r = new Random();
        //Generates the synthetic course list and returns a random element
        public Course RandomCourse()
        {
            List<Course> course = new List<Course>();
            DataCourses(ref course);
            return course[r.Next(0, course.Count)];
        }
        //Generates the synthetic student list and returns a random element
        public Student RandomStudents()
        {
            List<Student> student = new List<Student>();
            DataStudents(ref student);
            return student[r.Next(0, student.Count)];
        }
        //Generates the synthetic assignement list and returns a random element
        public Assignement RandomAssignement()
        {
            List<Assignement> assignement = new List<Assignement>();
            DataAssignements(ref assignement);
            return assignement[r.Next(0, assignement.Count)];
        }
        //Generates the synthetic student list and returns a random element
        public Trainer RandomTrainer()
        {
            List<Trainer> trainer = new List<Trainer>();
            DataTrainers(ref trainer);
            return trainer[r.Next(0, trainer.Count)];
        }
    }
}
