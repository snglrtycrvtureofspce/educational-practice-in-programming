using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person me = new Person("Sasha", "Samoilov", new DateTime(2004, 09, 07));
            Console.WriteLine($"Реализация ToShortString: \n{me.ToShortString()}\n_______________________");
            Console.WriteLine($"Реализация ToString: \n{me.ToString()}\n_______________________");
            Console.WriteLine($"Реализация метода get/set для получения года рождения: {me.BirthdayGetSet}");
            me.BirthdayGetSet = 2052;
            Console.WriteLine(
                $"Реализация метода get/set для получения года рождения: \n{me.ToString()}\n_______________________");
            Article first = new Article(me, "Отзывы на книги", 9.5);
            Console.WriteLine(first.ToString());
            Console.Write("Введите кол-во статей: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Article[] list = new Article[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Введите имя автора: ");
                string name = Console.ReadLine();
                Console.Write("Введите Фамилию автора: ");
                string surname = Console.ReadLine();
                Console.Write("Введите год рождения: ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите месяц рождения: ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите день рождения: ");
                int day = Convert.ToInt32(Console.ReadLine());
                Person man = new Person(name, surname, new DateTime(year, month, day));
                Console.Write("Введите название статьи: ");
                name = Console.ReadLine();
                Console.Write("Введите оценку статьи: ");
                int rate = Convert.ToInt32(Console.ReadLine());
                Article tab = new Article(man, name, rate);
                list[i] = tab;
            }
            Console.Write("Введите название журнала: ");
            
            Console.Write("Введите год выхода журнала: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день: ");
            int day = Convert.ToInt32(Console.ReadLine());
            DateTime data = new DateTime(year, month, day);
            Magazine topGear = new Magazine()
            for (int i = 0; i < size; i++)
            {
                int num = i + 1;
                Console.WriteLine($"Статья номер {num}");
                Console.WriteLine(list[i].ToString());
            }
            // Magazine Top = new Magazine("Top-Gear",,333)
        }

    }
}
