﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikaden14
{
    internal class Circle : Figure
    {
        private double a;

        public Circle(double a)
        {
            this.a = a;
        }

        public override double Ploshca()
        {
            return 3.14 * Math.Pow(a, 2);
        }

        public override double Perimetr()
        {
            return 2 * 3.14 * a;
        }

        public override void Show()
        {
            Console.WriteLine("КРУГ: Радиус r = {0}, Периметр {1} Площадь {2}.", a, Perimetr(), Ploshca());
        }

     
    }
}