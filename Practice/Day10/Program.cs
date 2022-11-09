using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
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
                    var x = new HashSet<int>(4){1, 2, 3, 4};
                    var x2 = new HashSet<int>(4){1, 2, 3, 4};
                    Lots a = new Lots(x, x2);
                    a.AddLots(7); // добавляем элемент, работаем только с x хэшем
                    a.RemoveLots(1); // удаляем элемент, работаем только с x хэшем
                    Console.WriteLine("Вывод:");
                    foreach (var i in x)
                    {
                        Console.WriteLine(i);
                    }
                    Console.WriteLine("_________");
                    Console.WriteLine($"Принадлежит ли элемент 2 множеству? - {a.IsLots(2)}");
                    Console.WriteLine($"Является ли множество подмножеством? - {a.IsSequenceLots()}");
                    Console.WriteLine($"Равны (не равны) ли два множества ? - {a.IsEqualLots()}");
                    a.UnLots(); // объединение
                    a.InterseLots(); // пересечение
                    Console.WriteLine(a.DiffAB()); // разность A и B
                    Console.WriteLine(a.DiffBA()); // разность B и A
                    Console.WriteLine(a.DiffLots()); // симметрическая разность двух множеств
                    break;
                }
                case 2:
                {
                    var x = "f22r5";
                    Console.WriteLine(x);
                    Lots a = new Lots(x);
                    Console.WriteLine(++a);
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
