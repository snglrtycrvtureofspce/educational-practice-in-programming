using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day17
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Введите номер задания: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    const string path = "numbers.txt";
                    var writer = new StreamWriter(path);
                    var num = 0;
                    var arr = Enumerable.Range(-6, 300).Select(x => x);
                    for (var i = -6; i < 301; i++)
                    {
                        try
                        {
                            writer.WriteLine(i);
                            num++;
                            if (i != 300) continue;
                            Console.WriteLine("Запись прошла успешна!" +
                                              $"\nСумма записанных чисел: {num}");
                            writer.Close();
                        }
                        catch (IOException e)
                        {
                            Console.WriteLine("Запись не прошла!");
                            break;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            break;
                        }
                    }
                    break;
                }
                case 2:
                {
                    while (true)
                    {
                        Console.Write("1 - Ввод строки с клавиатуры" +
                                      "\n2 - Считать строку с файла и вывести на экран" +
                                      "\n3 - Шифрование текста" +
                                      "\n4 - Расшифровка текста" +
                                      "\n5 - Очистка файлов" +
                                      "\n0 - Выход" +
                                      "\nВведите действие: ");
                        int p2 = Convert.ToInt32(Console.ReadLine());
                        if (p2 == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Завершение программы...");
                            break;
                        }
                        else if (p2 == 1)
                        {
                            try
                            {
                                const string path = "temp.txt";
                                var writer = new StreamWriter(path);
                                Console.Write("Введите строку для шифрования: ");
                                string encrypt = Console.ReadLine();
                                writer.Write(encrypt);
                                Console.Clear();
                                Console.WriteLine($"Успешно!");
                                writer.Close();
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("Запись не прошла!");
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                break;
                            }
                        }
                        else if (p2 == 2)
                        {
                            try
                            {
                                Console.Write("1 - Исходный текст файла" +
                                              "\n2 - Зашифрованный файл" +
                                              "\n3 - Расшифрованный файл" +
                                              "\nВведите действие: ");
                                int p22 = Convert.ToInt32(Console.ReadLine());
                                if (p22 == 1)
                                {
                                    const string path = "temp.txt";
                                    var reader = new StreamReader(path);
                                    Console.Clear();
                                    Console.WriteLine($"Исходная строка: {reader.ReadLine()}");
                                    reader.Close();
                                }
                                else if (p22 == 2)
                                {
                                    const string path = "decrypted.txt";
                                    var reader = new StreamReader(path);
                                    Console.Clear();
                                    Console.WriteLine($"Зашифрованная строка: {reader.ReadLine()}");
                                    reader.Close();
                                }
                                else if (p22 == 3)
                                {
                                    const string path = "encrypted.txt";
                                    var reader = new StreamReader(path);
                                    Console.Clear();
                                    Console.WriteLine($"Расшифрованная строка: {reader.ReadLine()}");
                                    reader.Close();
                                }
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("Чтение не прошло!");
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                break;
                            }
                        }
                        else if (p2 == 3)
                        {
                            try
                            {
                                const string path = "temp.txt";
                                var reader = new StreamReader(path);
                                string decrypt = reader.ReadToEnd();
                                string replace = "";
                                if (decrypt.Contains("ле") || decrypt.Contains("са") || decrypt.Contains("ик"))
                                {
                                    replace = decrypt.Replace("ле", "ю");
                                    replace = decrypt.Replace("са", "щ");
                                    replace = decrypt.Replace("ик", "ж");
                                }
                                else
                                {
                                    Console.WriteLine("Файл не содержит определённые буквы для шифровки");
                                }
                                var writer = new StreamWriter("decrypted.txt");
                                writer.Write(replace);
                                writer.Close();
                                reader.Close();
                                Console.Clear();
                                Console.WriteLine($"Шифровка завершена!");
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("Ошибка!");
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                break;
                            }
                        }
                        else if (p2 == 4)
                        {
                            try
                            {
                                const string path = "decrypted.txt";
                                var reader = new StreamReader(path);
                                string encrypt = reader.ReadToEnd();
                                string replace = "";
                                if (encrypt.Contains("ю") || encrypt.Contains("щ") || encrypt.Contains("ж"))
                                {
                                    replace = encrypt.Replace("ю", "ле");
                                    replace = encrypt.Replace("щ", "са");
                                    replace = encrypt.Replace("ж", "ик");
                                }
                                else
                                {
                                    Console.WriteLine("Файл не содержит определённых букв для расшифровки");
                                }
                                var writer = new StreamWriter("encrypted.txt");
                                writer.Write(replace);
                                Console.Clear();
                                Console.WriteLine($"Шифровка завершена!");
                                reader.Close();
                                writer.Close();
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("Ошибка!");
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                break;
                            }
                        }
                        else if (p2 == 5)
                        {
                            try
                            {
                                const string pathTemp = "temp.txt";
                                const string pathEncrypted = "encrypted.txt";
                                const string pathDecrypted = "decrypted.txt";
                                var writerTemp = new StreamWriter(pathTemp);
                                writerTemp.Write("");
                                var writerEncrypted = new StreamWriter(pathEncrypted);
                                writerEncrypted.Write("");
                                var writerDecrypted = new StreamWriter(pathDecrypted);
                                writerDecrypted.Write("");
                                writerTemp.Close();
                                writerEncrypted.Close();
                                writerDecrypted.Close();
                                Console.Clear();
                                Console.WriteLine("Файлы очищены!");
                            }
                            catch (IOException e)
                            {
                                Console.WriteLine("Ошибка!");
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                                break;
                            }
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
