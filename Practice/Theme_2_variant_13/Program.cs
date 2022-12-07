using System;

namespace extends_theme2_variant13
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char p;
            Console.Write("Введите целое число: "); 
            var N = Convert.ToInt32(Console.ReadLine());
            if(N % 11 == 0)
            {
                p = 'A';
            }
            else if (N > 100 || (N < 10 && N > 0))
            {
                p = 'B';
            }
            else if(N < -20)
            {
                p = 'C';
            }
            else
            {
                p = 'D';
            }
            switch (p)
            {
                case 'A':
                    {
                        Console.WriteLine($"Число {N} относится к группе {p}");
                        break;
                    }
                case 'B':
                    {
                        Console.WriteLine($"Число {N} относится к группе {p}");
                        break;
                    }
                case 'C':
                    {
                        Console.WriteLine($"Число {N} относится к группе {p}");
                        break;
                    }
                case 'D':
                    {
                        Console.WriteLine($"Число {N} относится к группе {p}");
                        break;
                    }
            }
        }
    }
}
