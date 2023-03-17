using System;
using System.Threading.Tasks;

namespace Day24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    Task task1 = Task.Factory.StartNew(() => Console.WriteLine("Выполняется задание 1"));
                    Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Выполняется задание 2"));
                    Task task3 = Task.Factory.StartNew(() => Console.WriteLine("Выполняется задание 3"));
                    Task.WaitAll(task1, task2, task3);
                    break;
                }
                case 3:
                {
                    Task task1 = Task.Factory.StartNew(() => Console.WriteLine("Выполняется задание 1"));
                    Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Выполняется задание 2"));
                    var result = 1 * 2 * 3 * 4 * 5;
                    Task.WaitAll(task1, task2);
                    Console.WriteLine("Результат " + result);
                    break;
                }
                case 4:
                {
                    Parallel.For(1, 3, i =>
                    {
                        Console.WriteLine($"Выполняется задача {i}:");
                        var sum = 0;
                        for (int j = 1; j <= i; j++)
                        {
                            sum += j;
                        }
                        Console.WriteLine($"Сумма {i} чисел равна: {sum}");
                    });
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