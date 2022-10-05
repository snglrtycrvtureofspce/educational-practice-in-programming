using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sort;
namespace Day05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            try
            {
                switch (p)
                {
                    case 1:
                    {
                        const int n = 9;
                        int min = 1, max = 1, temp = 0;
                        int[] arr = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            arr[i] = rnd.Next(-100, 100);
                        }

                        foreach (int i in arr)
                        {
                            Console.WriteLine($"{i} \t");
                        }

                        for (int i = 0; i < n; i++)
                        {
                            if (arr[i] < arr[min])
                            {
                                min = i;
                            }
                            else if(arr[i] > arr[max])
                            {
                                max = i;
                            }
                        }
                        temp = arr[min];
                        arr[min] = arr[max];
                        arr[max] = temp;
                        Console.WriteLine("_________________");
                        foreach (int i in arr)
                        {
                            Console.WriteLine($"{i} \t");
                        }
                        break;
                    }
                    case 2:
                    {
                        const int n = 10;
                        int c = 0;
                        int[] x = new int[n], y = new int[n], s = new int[n];
                        bool flag;
                        Console.WriteLine("Введите массив X: ");
                        for (int i = 0; i < n; i++)
                        {
                            x[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("Введите массив Y: ");
                        for(int i = 0; i < n; i++)
                        {
                            y[i] = Convert.ToInt32(Console.ReadLine());
                            for(int j = 0; j < n; j++)
                                if(x[j] == y[i])
                                {
                                    s[c++] = y[i];
                                    break;
                                }
                        }
                        Console.WriteLine("Получившийся массив: ");
                        foreach (int i in s)
                        {
                            Console.WriteLine($"{i} \t");
                        }
                        break;
                    }
                    case 3:
                    {
                        int[] m = new int[7];
                        Console.WriteLine("Введите массив из 7 элементов: ");
                        for(int j = 0; j < 7; j++)
                        {
                            Console.Write(j + ": ");
                            m[j] = Convert.ToInt32(Console.ReadLine());
                            
                        }
                        //Строим новый массив
                        int[] n = new int[7];
                        for (int i = 0; i < 7; i++)
                        {
                            n[i] = m[i] / 10;
                        }
                        //Печатаем новый массив
                        Console.WriteLine("Получен новый массив: ");
                        for (int i = 0; i < 7; i++)
                        {
                            Console.WriteLine(n[i] + "\t");
                        }
                        break;
                    }
                    case 4:
                    {
                        int i, n, m, t;
                        int[,] A = new int[5, 4];
                        Random ran = new Random();
                        for (n = 0; n < 5; n++)
                        {
                            for (m = 0; m < 4; m++)
                            {
                                A[n, m] = ran.Next(1, 99);
                                Console.Write("{0}\t", A[n, m]);
                            }
                            Console.WriteLine();
                        }
                        m = 4;
                        n = 5;
                        for (i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n - 1; j++)
                            {
                                if (A[i, m - 1] > A[j, m-1])
                                {
                                    t = A[i, m - 1];
                                    A[i, m - 1] = A[j, m - 1];
                                    A[j, m - 1] = t;
                                }
                            }
                        }
                        Console.WriteLine();
                        for (n = 0; n < 5; n++)
                        {
                            for (m = 0; m < 4; m++)
                            {
                                Console.Write("{0}\t", A[n, m]);
                            }
                            Console.WriteLine();
                        }
                        break;
                    }
                    case 5:
                    {
                        int n = 3, x = n-1, y = n, d = -1, r =9;
                        int[,] a = new int[n, n];
                        for(int i = x; i >= 0; d *= -1)
                        {
                            for(int j = i; j >= 0; --j)
                            {
                                a[x, y += d] = r--;
                            }
                            for(int j = --i; j >= 0; --j)
                            {
                                a[x += d, y] = r--;
                            }
                        }
                         
                        for (int i = n-1; i >= 0; i--)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                Console.WriteLine(a[i, j]);
                            }
                            Console.WriteLine("\n");
                        }
                        break;
                    }
                    case 6:
                    {
                        const int n = 5;
                        int[,] arr = new int[n, n];
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                arr[i, j] = rnd.Next(-100, 100);
                                Console.Write(arr[i, j] + "\t");
                            }
                            Console.Write("\n");
                        }
                        Console.WriteLine("____________________________________"); 
                        // из двухмерного в одномерный
                        int[] arr2 = new int[n * n];
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n; j++)
                            {
                                arr2[n * i + j] = arr[i, j];
                            }
                        }

                        Console.Write("\n1 - Сортировка пузырьком" +
                                          "\n2 - Сортировка вставкой" +
                                          "\n3 - Сортировка выбором" +
                                          "\nВыберите функцию сортировки: ");
                        int p_2 = Convert.ToInt32(Console.ReadLine());
                        switch (p_2)
                        {
                            case 1:
                            {
                                buble bbl = new buble();
                                bbl.BubbleSort(arr2);
                                for (int i = 0; i < n * n; i++)
                                {
                                    if (i == 5 || i == 10 || i == 15 || i == 20)
                                    {
                                        Console.WriteLine();
                                    }
                                    Console.Write(arr2[i]);
                                    Console.Write("\t");
                                }
                                Console.WriteLine();
                                break;
                            }
                            case 2:
                            {
                                insert ins = new insert();
                                ins.InsertionSort(arr2);
                                for (int i = 0; i < n * n; i++)
                                {
                                    if (i == 5 || i == 10 || i == 15 || i == 20)
                                    {
                                        Console.WriteLine();
                                    }
                                    Console.Write(arr2[i]);
                                    Console.Write("\t");
                                }
                                Console.WriteLine();
                                break;
                            }
                            case 3:
                            {
                                choice chc = new choice();
                                chc.SelectionSort(arr2);
                                for (int i = 0; i < n * n; i++)
                                {
                                    if (i == 5 || i == 10 || i == 15 || i == 20)
                                    {
                                        Console.WriteLine();
                                    }
                                    Console.Write(arr2[i]);
                                    Console.Write("\t");
                                }
                                Console.WriteLine();
                                break;
                            }
                            default:
                            {
                                Console.WriteLine("Exit...");
                                break;
                            }
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
