using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03
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
                    int A = 3, B = 4;
                    if (A % 2 != 0 && B % 2 != 0)
                    {
                        Console.WriteLine("Число A и B - нечётное");
                    }
                    else
                    {
                        break;
                    }
                    break;
                }
                case 2:
                {
                    int k = 4, l = 2, n = 3, m = 5;
                    if (k == 0)
                    {
                        if (l > m)
                        {
                            //...
                        }
                    }
                    else if (k < 0)
                    {
                        if (2*l-3*n < m)
                        {
                            //...
                        }
                    }
                    break;
                }
                case 3:
                {
                    int x1 = 1, x2 = 2;
                    Console.WriteLine("Введите координаты точек A(q,a)\nВведите Aq: ");
                    int Aq = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите Aa: ");
                    int Aa = Convert.ToInt32(Console.ReadLine());
                    if (Aq >= x1 && x2 >= Aa)
                    {
                        Console.WriteLine("Входит в данную область");
                    }
                    else
                    {
                        Console.WriteLine("Не входит в данную область");
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
