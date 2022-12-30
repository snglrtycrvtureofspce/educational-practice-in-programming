using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikaden14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pl1 = 1;
            int pl2 = 50;

            Figure[] mas = new Figure[3] {
                new Circle(5),
                new Triangle(10, 6, 8, 4),
                new Rectangle(8, 12)
            };
            
            Array.Sort(mas,(x,y)=>x.Ploshca().CompareTo(y.Ploshca()));

            foreach(Figure figure in mas)   
            {
                figure.Show();
            }

            Console.WriteLine("Поиск фигур в диапазоне площади от 1 до 50:\n");
            foreach (Figure f in mas)
            {
                if (pl1 < f.Ploshca() && f.Ploshca() < pl2)
                {
                    f.Show();
                }
            }

            Console.ReadLine();
        }
    }
}