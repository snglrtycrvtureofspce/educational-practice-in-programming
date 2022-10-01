using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Day04
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
                        double sum = 0.0, sum_2 = 0.0;
                        Console.Write("Введите вещественное число A: ");
                        double A = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите целое число N: ");
                        int N = Convert.ToInt32(Console.ReadLine());
                        if (N <= 0)
                        {
                            throw new ArgumentOutOfRangeException("N", "Требуется значение больше нуля!");
                        }
                        for (int i = 0; i < N; i++)
                        {
                            sum += Math.Pow(A, N);
                        }

                        for (int i = 0; i < N; i++)
                        {
                            sum_2 += Math.Pow(A, -N);
                        }
                        Console.WriteLine($"Первая сумма: {sum}");
                        Console.WriteLine($"Вторая сумма: {sum_2}");
                        break;
                    }
                    case 2:
                    {
                        double fact(int N)
                        {
                            if (N == 1)
                            {
                                return 1;
                            }
                            return N * fact(N - 1);
                        }
                        double W = 0.0;
                        Console.Write("Введите k: ");
                        int k = Convert.ToInt32(Console.ReadLine());
                        for (int i = -2; i <= k; i++)
                        {
                            try
                            {
                                if (i == 4)
                                {
                                    break;
                                }
                                W += (Math.Pow(-1, i) * fact(i + 3)) / (i - 4);
                            }
                            catch (StackOverflowException e)
                            {
                                Console.WriteLine(e); 
                                break;
                            }
                        }
                        Console.WriteLine($"Сумма конечного ряда: {W}");
                        break;
                    }
                    case 3:
                    {
                        int i = 1, sum = 0;
                        Console.Write("Введите N(максимальное число):");
                        int n = Convert.ToInt32(Console.ReadLine());
                        while (i <= n)
                        {
                            if ((i%5 != 0) && (i % 3 == 0))
                            {
                                Console.WriteLine($"Число которое не кратно пяти и кратно трём: {i}");  
                                sum += i;
                            }
                            i++;
                        }
                        Console.WriteLine($"Сумма: {sum}");
                        break;
                    }
                    case 4:
                    {
                        int i=100;
                        do
                        {
                            Console.WriteLine(i);
                            
                            i += 200;
                        } while (i < 800);
                        break;  
                    }
                    case 5:
                    {
                        int s = 0;
                        string q = default, r = default;
                        for (int i = 1; i < 100; i++)
                            if ((q = (i * i).ToString()) == (r = new string(q.Reverse().ToArray())))
                                Console.WriteLine($"palindrome {++p} q={q} == r={r}"); ;
                        Console.WriteLine($"total: {s}");
                        break;
                    }
                    case 6:
                    {
                        Console.Write("Введите x: ");
                        int x = Convert.ToInt32(Console.ReadLine());
                        int N = -1;
                        do
                        {
                            Console.Write("Введите N (N > 0): ");
                            N = Convert.ToInt32(Console.ReadLine());
                        } while (N < 0);
                        double t = Math.Cos(x);
                        double sum = t;
                        for (int i = 1; i < N; i++)
                        {
                            t = t * x * x / i;
                            sum += t * (2 * i + 1);
                        }
                        Console.WriteLine($"Сумма: {sum}");
                        break;
                    }
                    case 7:
                    {
                        for (double i = 0.1; i <= 2.2; i+= .2)
                        {
                            Console.WriteLine($"x = {i}\ny = {f(i)}");
                        }
                        double f(double x)
                        {
                            return Math.Pow(x, 2) - Math.Pow(Math.Cos(x + 1), 2);
                        }
                        break;
                    }
                    case 8:
                    {
                        for (double i = -2; i <= 3; i+= .2)
                        {
                            Console.WriteLine($"x = {i}\ny = {f(i)}");
                        }
                        double f(double x)
                        {
                            if (x > 1.5)
                            {
                                return Math.Pow(2.5, 3) + 6 * Math.Pow(x, 2) - 30;
                            }
                            else if (0 <= x && 0 <= 1.5)
                            {
                                return x + 1;
                            }
                            else if (x < 0)
                            {
                                return x;
                            }
                            return 0;
                        }
                        break;
                    }
                    case 9:
                    {
                        for (double i = Math.PI / 2; i <= 2 * Math.PI; i+= Math.PI / 4)
                        {
                            Console.WriteLine($"f(x) = {i}\ny = {f(i)}");
                        }
                        double f(double x)
                        {
                            if (x > Math.PI)
                            {
                                return Math.Pow(Math.Cos(x), x);
                            }
                            else if (x <= Math.PI)
                            {
                                return Math.Pow(x, Math.Cos(x));
                            }
                            return 0;
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
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }
        }
    }
}
