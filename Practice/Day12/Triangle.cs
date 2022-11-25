using System;

namespace Day12
{
    public enum Frencuency {Равносторонний, Прямоугольный, Равнобедренный}
    public class Triangle
    {
        public DateTime datecreate = DateTime.Now;
        public Frencuency typeoftriangle;
        private int _a, _b, _c;
        public Triangle(){}

        public Triangle(int a, int b, int c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
            if (a == b && a == c)
            {
                this.typeoftriangle = Frencuency.Равносторонний;
            }
            else if (a == b || b == c || a == c)
            {
                this.typeoftriangle = Frencuency.Равнобедренный;
            }
            else
            {
                this.typeoftriangle = Frencuency.Прямоугольный;
                
            }
        }
        public int A
        {
            set => this._a = value;
            get => this._a;
        }

        private int B
        {
            set => this._b = value;
            get => this._b;
        }

        public int C
        {
            set => this._c = value;
            get => this._c;
        }
        public string this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:
                        return Convert.ToString(this._a);
                    case 1:
                        return Convert.ToString(this._b);
                    case 2:
                        return Convert.ToString(this._c);
                    default:
                        return "Ошибка! Неверный индекс.";
                }
            }
        }

        public static Triangle operator ++(Triangle temp)
        {
            return new Triangle(++temp._a, ++temp._b, ++temp._c);
        }
        public static Triangle operator --(Triangle temp)
        {
            return new Triangle(--temp._a, --temp._b, --temp._c);
        }

        public static bool operator true(Triangle temp)
        {
            return temp.isTriangle();
        }

        public static bool operator false(Triangle temp)
        {
            return temp.isTriangle();
        }

        public static Triangle operator *(Triangle temp, int scalar)
        {
            return new Triangle(temp._a *= scalar, temp._b *= scalar, temp._c *= scalar);
        }

        public int Perimeter()
        {
            return _a + _b + _c;
        }
            
        public double Area(int R)
        {
            return 2 * Math.Pow(R, 2) * Math.Sign(_a) * Math.Sin(_b) * Math.Sin(_c);
        }

        public bool isTriangle()
        {
            if (_a + _b > _c && _a + _c > _b && _b + _c > _a)
            {
                return true;
            }
            throw new ArgumentOutOfRangeException();
        }

        public override string ToString()
        {
            return $"Информация о треугольнике:\nДата создания: {datecreate}\nСторона a: {this._a}\nСторона b: {this._b}\nСторона c: {this._c}\nТип треугольника:{this.typeoftriangle}";
        }
    }
}