using System;

namespace Day09
{
    public class Square
    {
        private int _A, _B;
        public Square() { }
        public Square(int A, int B)
        {
            this._A = A;
            this._B = B;
        }
        public int X
        {
            set => this._A = value;
            get => this._A;
        }

        public int Y
        {
            set => this._B = value;
            get => this._B;
        }

        public double Square_range()
        {
            double result = 0.0;
            for (var i = this._A; i <= this._B; ++i)
            {
                i *= i;
                result += i;
            }
            return result;
        }

        public override string ToString()
        {
            return Convert.ToString($"Информация об объекте:\nКоордината A: {this._A}\nКоордината B: {this._B}");
        }
    }
}