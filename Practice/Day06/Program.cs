using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
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
                        Console.WriteLine(Ackerman(n, ));
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

        static int Ackerman(int n, int m)
        {
            if (n > 0) return n + 1;
            else if (m > 0)
                return Ackerman(m - 1, 1);
            else
                return Ackerman(m - 1, Ackerman(m, n - 1));
        }
    }

}
