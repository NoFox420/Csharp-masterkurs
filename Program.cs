
using System;
using System.Security.Cryptography.X509Certificates;

namespace Csharp_masterkurs

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleInClassroom =
            {
                new Teacher("John", "Smith", 32),
                new Student("Sabrina", "Müller", 18),
                new Student("Anna", "Matt", 17),
                new Student("Peter", "Fredl", 18),
                new Student("Matthias", "Maier", 19)
            };

            foreach (Person p in peopleInClassroom)
            {
                p.PrintInformation();

                if (p is Teacher)
                {
                    (p as Teacher).Teach();
                }
                else if (p is Student) 
                {
                    (p as Student).ListenToTeacher();
                }
                Console.WriteLine();
            }
        }
    }

    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public Person(string firstName, string lastName, int age) 
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public void PrintInformation()
        {
            Console.WriteLine("Name: {0} {1}", FirstName, LastName);
            Console.WriteLine("Alter: {0}", Age);
        }
    }

    class  Teacher : Person
    {
        public Teacher(string firstName, string lastName, int age) : base(firstName, lastName, age) 
        {
            
        }
        public void Teach()
        {
            Console.WriteLine("Herr/Frau {0} unterrichtet die Klasse!", LastName);
        }

    }

    class Student : Person
    {
        public Student(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
            
        }

        public void ListenToTeacher()
        {
            Console.WriteLine("Der/Die Schüler/in {0} {1} hört dem Lehrer zu!", FirstName, LastName);
        }
    }
}
