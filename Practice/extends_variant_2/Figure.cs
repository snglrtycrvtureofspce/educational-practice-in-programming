using System;

namespace extends_variant2
{
    abstract class Figure
    {
        public abstract double Perimetr();
    }

    class Rectangle : Figure
    {
        protected double _a;

        public Rectangle() {}

        public Rectangle(double a)
        {
            this._a = a;
        }

        public double A
        {
            set => this._a = value;
            get => this._a;
        }

        public override double Perimetr()
        {
            return Math.Pow(this._a, 2);
        }

        public override string ToString()
        {
            return $"Информация об объекте:\nСторона а: {this._a}\nПериметр: {Perimetr()}";
        }
    }

    class Triangle : Rectangle
    {
        private double _b, _c;
        public Triangle() : base()
        {}
        public Triangle(double a, double b, double c) : base(a)
        {
            this._b = b;
            this._c = c;
        }

        public double A
        {
            set => this._a = value;
        }
        public double B
        {
            set => this._b = value;
        }

        public double C
        {
            set => this._c = value;
        }

        public override double Perimetr()
        {
            return this._a + this._b + this._c;
        }

        public override string ToString()
        {
            return $"Информация об объекте:\nСторона a: {this._a}\nСторона b: {this._b}\nСторона c: {this._c}\nПериметр: {Perimetr()}";
        }
    }
}