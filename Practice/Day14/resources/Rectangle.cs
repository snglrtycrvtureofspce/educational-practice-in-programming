using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikaden14
{
    internal class Rectangle : Figure
    {
        private int a;
        private int b;


        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
          

        }

        public override double Perimetr()
        {
            return (a + b) * 2;

        }

        public override double Ploshca()
        {
            return a * b;
        }

        public override void Show()
        {
            Console.WriteLine("ПРЯМОУГОЛЬНИК: Сторона a = {0} Сторона b = {1}, Периметр {2} Площадь {3}.", a, b, Perimetr(), Ploshca());
        }

       
    }
}