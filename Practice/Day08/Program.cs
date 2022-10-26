using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    string s = "4190672H011PB3" +
                               "MC2520033";
                    Console.WriteLine("Исходная строка: "+ s);
                    Regex regex = new Regex("(?i)[1-6]{1}[0-9]{6}[A-Z]{1}[0-9]{3}[GB|PB|BA|BI]{2}[0-9]{1}");
                    Regex regex2 = new Regex("(?i)[A-Z]{2}[0-9]{7}");
                    Console.WriteLine("Ввод идентификационного номера корректен? - " + regex.IsMatch(s));
                    Console.WriteLine("Ввод номера паспорта корректен? - " + regex2.IsMatch(s));
                    break;
                }
                case 2:
                {
                    string temp = null;
                    string s = "http://www.regexcookbook.com";
                    Regex regex = new Regex("^(https?:\\/\\/)?([\\w-]{1,32}\\.[\\w-]{1,32})[^\\s@]*");
                    if (regex.IsMatch(s))
                    {
                        temp = $"<a href=\"{s}\">{s}</a>";
                    }
                    Console.WriteLine(temp);
        
                    break;
                }
                case 3:
                {
                    string s = "\n+375(33)358-94-89;15.11.2004;6sec\n" +
                               "+375(33)358-94-89;15.11.2004;3sec\n" +
                               "+375(33)358-94-89;15.11.2004;55sec\n" +
                               "+375(33)358-94-89;15.11.2004;25sec\n" +
                               "+375(33)358-94-89;15.11.2004;5min\n" +
                               "+375(33)358-94-89;15.11.2004;27sec\n";
                    Console.WriteLine("Исходный текст: " + s);
                    Regex regex = new Regex("(?i)[0|1|2|3|4]{1}[sec|min]{3}");
                    /* Console.WriteLine("Время связи меньше 5-ти секунд: " + regex.IsMatch(s));*/
                    /*Regex.Matches(s, "(?i)[0|1|2|3|4]{1}[sec|min]{3}");*/
                    Match tels = regex.Match(s);
                    while (tels.Success)
                    {
                        Console.WriteLine(tels);
                        tels = tels.NextMatch();
                    }
                    break;
                }
                case 4:
                {
                    string path = "C:\\Users\\snglrtycrvtureofspce\\Documents\\snglrtycrvtureofspce\\GitHub\\" +
                                  "educational-practice-in-programming\\Practice\\Day08\\example.txt";
                    FileInfo fi = new FileInfo(path);   
                    if (fi.Exists)
                    {
                        fi.Delete();
                    }

                    using (FileStream fs = fi.Create())
                    {
                        Byte[] info = new UTF8Encoding(true).GetBytes("Its key is {3F2504E0-4F89-UDD3-9A0C-0305E82C3301}.");
                        fs.Write(info, 0, info.Length);
                    }

                    Regex regex = new Regex("(?i)\\b[0-9a-zA-Z]{8}\\-[0-9a-zA-Z]{4}\\-[0-9a-zA-Z]{4}\\-[0-9a-zA-Z]{4}\\-[0-9a-zA-Z]{12}\\b");

                    using (StreamReader sr = fi.OpenText())
                    {
                        string s = "";
                        while ((s = sr.ReadLine()) != null)
                        {
                            Console.WriteLine(s);
                            Console.WriteLine("GUID - "+ regex.IsMatch(s));
                        }
                    }
                    break;
                }
                case 5:
                {                        
                    string r =
                        @"(?i)\b" +
                        @"[0-9a-zA-Z]{8}\-" +
                        @"[0-9a-zA-Z]{4}\-" +
                        @"[0-9a-zA-Z]{4}\-" +
                        @"[0-9a-zA-Z]{4}\-" +
                        @"[0-9a-zA-Z]{12}" +
                        @"\b";
                    string text = "Its key is {3F2504E0-4F89-UDD3-9A0C-0305E82C3301}.";
                    Console.WriteLine(Regex.Match(text, r).Index); // 12
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
