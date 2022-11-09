using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day09
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
                    Square sqr = new Square(2, 4);
                    Console.WriteLine(sqr.ToString());
                    Console.WriteLine($"Квадрат длины диапазона: {sqr.Square_range()}");
                    break;
                }
                case 2:
                {
                    Time tm = new Time(2, 30, 40);
                    Console.WriteLine(tm.ToString());
                    Console.WriteLine($"Количество полных минут в указанном промежутке: {tm.count_minutes()}мин");
                    Console.WriteLine($"Уменьшаем время на десять минут: {tm.minus_minutes()}мин");
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
