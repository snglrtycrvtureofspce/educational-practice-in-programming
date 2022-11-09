using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10_02
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
                    DateTime date1 = new DateTime(1996, 6, 3, 22, 15, 0);
                    DateTime date2 = new DateTime(1996, 12, 6, 13, 2, 0);
                    DateTime date = new DateTime(2022,1,22,4,7,13);
                    Time a = new Time(date1, date2);
                    Console.Write($"Разность в секундах двух отрезков времени: {a.DiffSec()}");
                    a.LagBeTime(1313413);
                    Console.WriteLine(a.ToString()); // не использовано
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
