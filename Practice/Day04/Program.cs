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
                        int a, i = 100;
                        while (i <= 700)
                        {
                            a = i / 100;
                            if (a % 2 != 0)
                            {
                                Console.WriteLine(i);
                            }
                            i++;
                        }
                        break;
                    }
                    case 5:
                    {
                        int num, sum = 0;
                        while (num = Console.ReadLine() != 0 && num != 0)
                        {
                            
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
