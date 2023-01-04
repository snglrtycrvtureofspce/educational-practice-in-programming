using System;

namespace Day18
{
    [Serializable]
    public abstract class Figure
    {
        public abstract double Perimeter();
        public abstract double Square();
    }

    public class Circle : Figure
    {
        protected double _l; // длина окружности
        protected double _r; // радиус
        public Circle () {}
        public Circle(double l, double r)
        {
            this._l = l;
            this._r = r;
        }
        public double L
        {
            set => this._l = value;
            get => this._l;
        }

        public double R
        {
            set => this._r = value;
            get => this._r;
        }

        public override double Perimeter()
        {
            return 2 * Math.PI * this._r;
        }

        public override double Square()
        {
            return Math.Pow(this._l, 2) / (4 * Math.PI);
        }

        public override string ToString()
        {
            return $"Информация об объекте: \n" +
                   $"Длина окружности: {this._l}\n" +
                   $"Радиус: {this._r}\n";
        }
    }

    public class Cylinder : Circle
    {
        private double _h; // высота цилиндра
        public Cylinder () : base () {}

        public Cylinder(double l, double r, double h) : base(l, r)
        {
            this._h = h;
        }
        public double H
        {
            set => this._h = value;
            get => this._h;
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * this._r;
        }

        public override double Square()
        {
            return 2 * Math.PI * this._r * (this._h + this._r);
        }
        public override string ToString()
        {
            return $"Информация об объекте: \n" +
                   $"Длина окружности: {this._l}\n" +
                   $"Радиус: {this._r}\n" +
                   $"Высота окружности: {this._h}\n";
        }
    }
}