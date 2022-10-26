using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
                    string[] arr = "Просто обычный пример теkста! Проверим kаkие слова будут содержать букву k".Split();
                    Console.WriteLine("Исходный текст: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        Console.Write(arr[i] + " ");
                    }
                    Console.WriteLine("\nБуква k найдена:");
                    foreach (string arr2 in arr.Where(k => k.Contains("k")))
                    {
                        Console.WriteLine(arr2);
                    }
                    break;
                }
                case 3:
                {
                    char[] arr = new char[16];
                    Console.WriteLine("Начальный массив: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        arr[i] = (char)rnd.Next(0x0030, 0x0070); // https://unicode-table.com/ru/
                        Console.WriteLine(arr[i] + "\t");
                    }
                    char maxvalue = '0';
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (char.IsNumber(arr[i]))
                        {
                            if (arr[i] > maxvalue)
                            {
                                maxvalue = arr[i];
                            }
                        }
                    }
                    Console.WriteLine("Наибольшее целое число - " + maxvalue);
                    break;
                }
                case 4:
                {
                    string[] arr = "Просто обычный пример теkста! Нам просто нужно добавить символ в конец строки!".Split();
                    Console.WriteLine("Исходный текст: ");
                    foreach (var t in arr)
                    {
                        Console.Write(t + " ");
                    }
                    Console.WriteLine("\nПолучившийся текст: ");
                    for (int i = 0; i < 1; i++)
                    {
                        arr[arr.Length - 1] += "<>";
                    }
                    foreach (var t in arr)
                    {
                        Console.Write(t + " ");
                    }
                    Console.WriteLine();
                    break;
                }
                case 5:
                {
                    string[] arr = "Просто обычный пример теkста! Нам просто нужно добавить символ в конец строки!".Split();
                    Console.WriteLine("Исходный текст: ");
                    foreach (var t in arr)
                    {
                        Console.Write(t + " ");
                    }
                    Console.WriteLine("\nПолучившийся текст: ");
                    for (int i = 0; i < 1; i++)
                    {
                        arr[arr.Length - 1] += $"{arr.Length}";
                    }
                    foreach (var t in arr)
                    {
                        Console.Write(t + " ");
                    }
                    Console.WriteLine();
                    break;
                }
                case 6:
                {
                    string[] arr = "Давайте заменим каждый символ: ! индексом этого символа, ! , пров ! f ка !".Split();
                    Console.WriteLine("Исходный текст: ");
                    foreach (var t in arr)
                    {
                        Console.Write(t + " ");
                    }
                    Console.WriteLine("\nПолучившийся текст: ");
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] == "!")
                        {
                            arr[i] = $"{i}";
                        }
                    }
                    foreach (var t in arr)
                    {
                        Console.Write(t + " ");
                    }
                    Console.WriteLine();
                    break;
                }
                case 7:
                {
                    Console.Write("Введите римскую цифру (от I до X): ");
                    string arr = Console.ReadLine();
                    switch (arr)
                    {
                        case "I":
                        {
                            Console.WriteLine("1");
                            break;
                        }
                        case "II":
                        {
                            Console.WriteLine("2");
                            break;
                        }
                        case "III":
                        {
                            Console.WriteLine("3");
                            break;
                        }
                        case "IV":
                        {
                            Console.WriteLine("4");
                            break;
                        }
                        case "V":
                        {
                            Console.WriteLine("5");
                            break;
                        }
                        case "VI":
                        {
                            Console.WriteLine("6");
                            break;
                        }
                        case "VII":
                        {
                            Console.WriteLine("7");
                            break;
                        }
                        case "VIII":
                        {
                            Console.WriteLine("8");
                            break;
                        }
                        case "IX":
                        {
                            Console.WriteLine("9");
                            break;
                        }
                        case "X":
                        {
                            Console.WriteLine("10");
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
    }
}
