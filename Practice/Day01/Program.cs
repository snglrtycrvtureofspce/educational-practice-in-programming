using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            if (p == 1)
            {
                Console.Write("Введите x: ");
                int x_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ответ: " + Base_01(x_1));
            }
            else if (p == 2)
            {
                Console.Write("Введите a: ");
                int a_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите t: ");
                int t_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите y: ");
                int y_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ответ: " + Average_01(a_1, t_1, y_1));
            }
            else if (p == 3)
            {
                Console.Write("Введите x: ");
                int x_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите y: ");
                int y_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите z: ");
                int z_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите c: ");
                int c_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ответ: " + High_01(x_1, y_1, z_1, c_1));
            }
            else if (p == 4)
            {
                Console.Write("Введите a: ");
                int a_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите b: ");
                int b_1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите H: ");
                int h_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ответ: " + Base_02(a_1, b_1,h_1));
            }
            else if (p == 5)
            {
                
            }
        }

        public static double Base_01 (int x)
        {
            return (1.51 * Math.Cos(Math.Pow(x, 2)) + 2 * Math.Pow(x, 3));
        }

        public static double Average_01 (int a, int t, int y)
        {
            return ((7.8 * Math.Pow(a, 2) + (3.52 * t)) / (Math.Log(a + (2 * y)) + Math.Exp(y)));
        }

        public static double High_01 (int x, int y, int z, int c)
        {
            return (Math.Tan(Math.Pow(x, 4) - 6) - Math.Pow(Math.Cos(z + x * y), 3)) /
                   (Math.Pow(Math.Cos(Math.Pow(x, 3) * Math.Pow(c, 2)), 4));
        }

        public static double Base_02 (int a, int b, int h)
        {
            return (((a + b) * h) * 1 / 2);
        }

        public static double High_02 ()
        {
            return;
        }
    }
}
