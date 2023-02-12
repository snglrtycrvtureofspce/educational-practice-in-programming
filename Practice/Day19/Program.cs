using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    string prefixExpression = "* + 2 3 4"; // Пример выражения в префиксной форме
                    Stack<int> operandStack = new Stack<int>();

                    // Переворачиваем строку, чтобы разбирать ее с конца
                    char[] chars = prefixExpression.ToCharArray();
                    Array.Reverse(chars);
                    prefixExpression = new string(chars);

                    // Разбираем строку, разбивая ее на токены
                    string[] tokens = prefixExpression.Split(' ');

                    // Обрабатываем каждый токен
                    foreach (string token in tokens)
                    {
                        // Если токен - операнд, помещаем его в стек
                        if (int.TryParse(token, out int operand))
                        {
                            operandStack.Push(operand);
                        }
                        else
                        {
                            // Берем два операнда из стека
                            int operand2 = operandStack.Pop();
                            int operand1 = operandStack.Pop();
                            Console.WriteLine(operand1 + ' ' + operand2);

                            // Выполняем операцию
                            int result = 0;
                            switch (token)
                            {
                                case "+":
                                    result = operand1 + operand2;
                                    break;
                                case "*":
                                    result = operand1 * operand2;
                                    break;
                                case "/":
                                    result = operand1 / operand2;
                                    break;
                            }

                            // Помещаем результат обратно в стек
                            operandStack.Push(result);
                        }
                    }

                    Console.WriteLine("Результат (последний элемент в стеке): " + operandStack.Pop());
                    break;
                }
                case 2:
                {
                    StreamReader reader = new StreamReader("file.txt");

                    Queue<string> upperCaseWords = new Queue<string>();
                    Queue<string> lowerCaseWords = new Queue<string>();

                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var words = line.Split(' ');

                        foreach (string word in words)
                        {
                            if (char.IsUpper(word[0]))
                            {
                                upperCaseWords.Enqueue(word); // Добавляет объект в конец очереди
                            }
                            else
                            {
                                lowerCaseWords.Enqueue(word);
                            }
                        }
                    }

                    reader.Close();

                    Console.WriteLine("Слова, начинающиеся с прописной буквы:");
                    while (upperCaseWords.Count > 0)
                    {
                        Console.WriteLine(upperCaseWords.Dequeue());
                    }

                    Console.WriteLine("Слова, начинающиеся со строчной буквы:");
                    while (lowerCaseWords.Count > 0)
                    {
                        Console.WriteLine(lowerCaseWords.Dequeue());
                    }

                    break;
                }
                case 3:
                {
                    var st = File.ReadAllLines("Task3.txt");
                    var students = new ArrayList(st.Length);
                    foreach (var line in st)
                    {
                        var f = line.Split(';', (char)StringSplitOptions.RemoveEmptyEntries);
                        var student = new Student(f[0], Convert.ToInt32(f[1]),
                            f[2].Split(';', (char)StringSplitOptions.RemoveEmptyEntries).ToArray());
                        students.Add(student);
                    }

                    students.Sort(new StudentsInfo());
                    foreach (var it in students)
                        Console.WriteLine(it);
                    Console.WriteLine();
                    if (File.Exists("Task3.txt"))
                        File.Create("Task3.txt").Close();
                    using (var writer = new StreamWriter("Task3.txt"))
                    {
                        var tmp = students.Cast<Student>().Where(x => x.IsDone).ToArray();
                        writer.Write(string.Join(";\n", tmp));
                        break;
                    }
                }
                case 4:
                {
                    Random rand = new Random();
                    string[] music = { "Маша", "Серёга Пират", "Автоспорт" };
                    string[] author = { "Серёга Пират", "Я взлетаю вверх", "Стой" };
                    string[] disk = { "1", "2", "3" };

                    MusicCatalog t1 = new MusicCatalog(music, author);
                    MusicCatalog t2 = new MusicCatalog(music.Select(x => $"{x} {rand.Next(0,10)}").ToArray(), author);
                    MusicCatalog t3 = new MusicCatalog(music.Select(x => $"{x} {rand.Next(0,10)}").ToArray(), author);
                    HashMusicCatalog hash = new HashMusicCatalog(disk, new MusicCatalog[] { t1, t2, t3});
                    hash.ShowAllMusicFromCatalogMusic();
                    hash.ShowAllMusicFromDisk("1");
                    hash.RemoveMusic("1","");
                    hash.ShowAllMusicOfAuthor("Серёга Пират");
                    break;
                }
                case 5:
                {
                    CSet<int> set1 = new CSet<int>() { 5, 6, 7, 8, 9 };
                    CSet<int> set2 = new CSet<int>() { 4, 5, 6, 7, 8 };
                    CSet<int> set3 = new CSet<int>() { 2, 3, 4 };
                    CSet<int> set4 = new CSet<int>() { 7, 8, 9 };

                    CSet<char> set5 = new CSet<char>() { '2', '3', '4', '5', '6' };
                    CSet<char> set6 = new CSet<char>() { '0', '1', '3', '2' , '6' };
                    CSet<char> set7 = new CSet<char>() { '3', '1', '9' };
                    CSet<char> set8 = new CSet<char>() { '2', '0', '9' };

                    Console.WriteLine("Множество (int) set1: " + set1);
                    Console.WriteLine("Множество (int) set2: " + set2);
                    Console.WriteLine("Множество (int) set3: " + set3);
                    Console.WriteLine("Множество (int) set4: " + set4);

                    Console.WriteLine("Множество (char) set5: " + set5);
                    Console.WriteLine("Множество (char) set6: " + set6);
                    Console.WriteLine("Множество (char) set7: " + set7);
                    Console.WriteLine("Множество (char) set8: " + set8);

                    // Объединение
                    CSet<int> setUnion = set1 + set2;
                    Console.WriteLine("(int) set1 + set2: " + setUnion);

                    CSet<char> setUnion2 = set5 + set6;
                    Console.WriteLine("(char) set5 + set6: " + setUnion2);

                    // Разница
                    CSet<int> setDiff = set1 - set2;
                    Console.WriteLine("(int) set1 - set2: " + setDiff);

                    CSet<char> setDiff2 = set5 - set6;
                    Console.WriteLine("(char) set5 - set6: " + setDiff2);

                    // Пересечение
                    CSet<int> setInter = set1 & set2;
                    Console.WriteLine("(int) set1 & set2: " + setInter);

                    CSet<char> setInter2 = set5 & set6;
                    Console.WriteLine("(char) set5 & set6: " + setInter2);

                    // Мощность множества
                    var pow = (int)set1;
                    Console.WriteLine($"Мощность множества set1(int): {pow}");

                    var pow2 = (char)set5;
                    Console.WriteLine($"Мощность множества set5(char): {pow2}");

                    // Сравнение множеств
                    Console.WriteLine(set3 <= set1
                        ? "(<=)(int)set3 является подмножеством set1"
                        : "(<=)(int)set3 не является подмножеством set1");

                    Console.WriteLine(set4 >= set2
                        ? "(>=)(int)set4 является надмножеством set2"
                        : "(>=)(int)set4 не является надмножеством set2");

                    Console.WriteLine(set7 <= set5
                        ? "(<=)(char)set7 является подмножеством set5"
                        : "(<=)(char)set7 не является подмножеством set5");

                    Console.WriteLine(set8 >= set6
                        ? "(>=)(char)set8 является надмножеством set6"
                        : "(>=)(char)set8 не является надмножеством set6");
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