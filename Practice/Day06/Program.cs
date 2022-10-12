using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (p)
                {
                    case 1:
                    {
                        Console.Write("Введите m: ");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите n: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Ackerman(m, n));
                        Console.WriteLine("__________________________");
                        Console.WriteLine(Simple_Ackerman(m, n));
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine(fifth());
                        break;
                    }
                    case 3:
                    {
                        int k = 20;
                        int[] arr = new int[1024];
                        sixth(k, arr);
                        break;
                    }
                    case 4:
                    {
                        Console.Write("Введите m: ");
                        int m = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Введите n: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(C(m, n));
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Exit...");
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
        }

        static int Ackerman(int m, int n)
        {
            if (n > 0) return n + 1;
            else if (m > 0)
                return Ackerman(m - 1, 1);
            else
                return Ackerman(m - 1, Ackerman(m, n - 1));
        }

        static int Simple_Ackerman(int m, int n)
        {
            if (n > 0)
            {
                return n + 1;
            }
            else if (m > 0)
            {
                for (int i = m - 1; m < 0; i++)
                {
                    n = 1;
                    return n + 1;
                }
            }
            else
            {
                return 1;
            }
            return 0;
        }

        static double fifth()
        {
            return ((2 + Math.Sin(2)) / (Math.Sin(5) + 5)) + ((6 + Math.Sin(6)) + (Math.Sin(3) + 3)) +
                   ((1 + Math.Sin(1)) / (Math.Sin(4) + 4));
        }

        static void sixth(int k, int[] x)
        {
            Random rnd = new Random();
            double avg = 0, disp = 0;
            x = new int[1024];

            for (int i = 0; i < k; i++)
            {
                x[i] = rnd.Next(-100, 100);
                avg += x[i];
            }
            avg /= k;

            for (int i = 0; i < k; i++)
            {
                disp += (x[i] - avg) * (x[i] - avg);
            }
            disp /= (k - 1);
            Console.WriteLine($"Среднее: {avg}\nДисперсия: {disp}");
        }
        static int C(int m, int n)
        {
            if (n > 0 && 0 <= m && m <= n)
            {
                return C(m, n - 1) + C(m - 1, n - 1);
            }
            return 1;
        }
    }

}
    