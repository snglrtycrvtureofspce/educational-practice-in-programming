using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите номер: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    char[] arr = new char[15];
                    Console.WriteLine("Начальный массив: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = (char)rnd.Next(0x0410, 0x44F); // https://unicode-table.com/ru/
                        Console.WriteLine(arr[i] + "\t");
                    }
                    Console.WriteLine("Конечный массив: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (char.IsLower(arr[i]))
                        {
                            Console.WriteLine(char.ToUpper(arr[i]));
                        }

                        if (char.IsUpper(arr[i]))
                        {
                            Console.WriteLine(char.ToLower(arr[i]));
                        }
                    }
                    break;
                }
                case 2:
                {
                    char[] arr = new char[15];
                    Console.WriteLine("Начальный массив: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = (char)rnd.Next(0x0410, 0x44F); // https://unicode-table.com/ru/
                        Console.WriteLine(arr[i] + "\t");
                    }

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
