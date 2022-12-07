using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14
{
    abstract class Persona : IComparable
    {
        public string Surname { get; set; }
        public DateTime Bday { get; set; }
        protected Persona(string Surname, byte dd, byte mm, short yyyy) 
        { 
            this.Surname = Surname;
            Bday = new DateTime(yyyy, mm, dd);
        }
        public int Age()
        {
            var age = DateTime.Now.Year - Bday.Year;
            if (DateTime.Now.Month < Bday.Month || (DateTime.Now.Month == Bday.Month && DateTime.Now.Month > Bday.Month))
               age -= 1;
            return age;
        }
        public int CompareTo(object o)
        {
            /*Persona p = o as Persona;
            if (p != null)*/
            if (o is Persona p)
                return this.Bday.CompareTo(p.Bday);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
        public override string ToString()
        {
            return Surname + '\n' +
                   Bday.Day + '.' + Bday.Month + '.' + Bday.Year + '\n';
        }
    }
    class Enrollee : Persona
    {
        public string Faculty { get; set; }
        public Enrollee(string Surname, byte dd, byte mm, short yyyy, string Faculty) : base(Surname, dd, mm, yyyy)
        {
            this.Faculty = Faculty;
        }
        public override string ToString()
        {
            return base.ToString()+
                   Faculty + '\n';
                
        }
    }
    class Student : Persona
    {
        public string Faculty { get; set; }
        public byte Course { get; set; } 
        public Student(string Surname, byte dd, byte mm, short yyyy, string Faculty, byte Course) : base(Surname, dd, mm, yyyy)
        {
            this.Faculty = Faculty;
            this.Course = Course;
        }
        public override string ToString()
        {
            return base.ToString() +
                   Faculty + '\n' +
                   Course + '\n';
        }
    }
    class Teacher : Persona
    {
        public string Faculty { get; set; }
        public string Position { get; set; }
        public byte Seniority { get; set; }
        public Teacher(string Surname, byte dd, byte mm, short yyyy, string Faculty, string Position, byte Seniority) : base(Surname, dd, mm, yyyy)
        {
            this.Faculty = Faculty;
            this.Position = Position;
            this.Seniority = Seniority;
        }
        public override string ToString()
        {
            return base.ToString() +
                Faculty + '\n' +
                Position + '\n' +
                Seniority + '\n';
        }
    }
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    int age1 = 16, age2 = 60;
                    Persona[] university = new Persona[3] {
                        new Teacher("Шаляпин", 01, 09, 1975, "Cyber Security", "C++ WinForms Developer", 5),
                        new Student("Тараскевич", 08, 10, 2004, "Software Development", 3),
                        new Enrollee("Самойлов", 07, 09, 2004, "Economics")
 
                    };
                    Console.WriteLine("Информация о персонах: ");
                    Array.Sort(university);
                    foreach (Persona pers in university)
                        Console.WriteLine(pers.ToString());
                    Console.WriteLine("Сортировка по дате рождения:\n");
                    foreach (Persona pers in university)
                        if (age1 < pers.Age() && pers.Age() < age2)
                            Console.WriteLine(pers.ToString());
                    break;
                }
                default:
                {
                    Console.WriteLine("Exit...");
                    break;
                }
            }
        }
    }
}
