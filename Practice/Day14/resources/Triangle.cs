using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikaden14
{
    internal class Triangle : Figure
    {
        private int a;
        private int b;
        private int c;
        private int h;

        public Triangle(int a, int b, int c, int h)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.h = h;

        }

        public override double Perimetr()
        {
            double p;
            p = a + b + c;
            return p;

        }

        public override double Ploshca()
        {
            double s;
            s = 0.5 * a * h;
            return s;
        }

        public override void Show()
        {
            Console.WriteLine("ТРЕУГОЛЬНИК: Сторона a = {0} Сторона b = {1} Сторона c = {2} и высота h = {3}, Периметр {4} Площадь {5}.", a, b, c, h, Perimetr(), Ploshca());
        }
     

    }
}