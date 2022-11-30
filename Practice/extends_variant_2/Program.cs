using System;
using System.Collections.Generic;

namespace extends_variant_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle recA = new Triangle(21, 23, 4);
            Triangle rec = new Triangle(8, 4, 71);
            Console.WriteLine("----------Родитель - Rectangle, дочерний - Triangle----------");
            Console.WriteLine(recA.ToString());
            Console.WriteLine("----------Triangle - как Triangle----------");
            Console.WriteLine(rec.ToString());
            Console.WriteLine("--------GET (A), SET (A) + Perimetr()----------");
            recA.A = 5;
            rec.B = 3;
            Console.WriteLine("Показываем свойства: (A становится 5, B становится 3)");
            Console.WriteLine("Показываем периметр:");
            Console.WriteLine("----------Родитель - Rectangle, дочерний - Triangle----------");
            Console.WriteLine(recA.ToString());
            Console.WriteLine("----------Triangle - как Triangle----------");
            Console.WriteLine(rec.ToString());
            recA.Perimetr();
            Console.WriteLine(rec.ToString());
            rec.Perimetr();
            (recA as Triangle).Perimetr();
            ((Triangle)rec).Perimetr();
            var bs = new List<Figure>
                        {
                            rec,
                            recA,
                            new Triangle()
                        };

            foreach (var item in bs)
            {
                Console.WriteLine(item.ToString()); // для всех
                if (item is Rectangle) (item as Rectangle).Perimetr(); // только для тех  у кого реализован метод Service
                
            }
        }
    }
}
