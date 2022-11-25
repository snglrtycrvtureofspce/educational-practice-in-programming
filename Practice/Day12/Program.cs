using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    Triangle a = new Triangle(3, 4, 5);
                    Console.WriteLine(a.ToString());
                    Console.WriteLine($"Является ли треугольником? - {a.isTriangle()}");
                    Console.WriteLine($"Периметр: {a.Perimeter()}");
                    Console.WriteLine($"Площадь: {a.Area(3)}");
                    Console.WriteLine("Работа индексатора: ");
                    Console.WriteLine("Первый индекс: " + a[0]);
                    Console.WriteLine("Второй индекс: " + a[1]);
                    Console.WriteLine("Третий индекс: " + a[2]);
                    Console.WriteLine("Четвёртый индекс (которого не должно существовать): " + a[3]);
                    Console.WriteLine("Работа перегрузок: ");
                    Console.WriteLine(a++);
                    Console.WriteLine(a--);
                    if (a)
                    {
                        Console.WriteLine("Треугольник с такими сторонами существует.");
                    }
                    else
                    {
                        Console.WriteLine("Треугольник с такими сторонами не существует.");
                    }
                    Console.WriteLine("Умножаем на 2: " + a * 2);
                    break;
                }
                case 2:
                {
                    
                    Triangle a = new Triangle(4, 5, 6);
                    Console.WriteLine(a.ToString());
                    Console.WriteLine("Свойства: ");
                    a.A = 2;
                    Console.WriteLine("Заменяем Сторону а на 2: " + a.A);
                    Console.WriteLine(a.ToString());
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