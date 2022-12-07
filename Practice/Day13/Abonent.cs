using System;

namespace Day13
{
    public class Abonent : Time
    {
        private int _hour, _minute, _second;
        private string _surname, _oper;
        public Abonent(){}
        public Abonent(string surname, string oper, int hour, int minute, int second) : base (hour, minute, second)
        {
            this._surname = surname;
            this._oper = oper;
        }

        public void Preferential()
        {
            if (this.hour >= 0 && this.hour <= 8)
            {
                Console.WriteLine("Время является льготным для абонента.");
            }
            else
            {
                Console.WriteLine("Время не является льготным для абонента!");
            }
        }
        public override string ToString()
        {
            return Convert.ToString($"Информация об объекте:\nТекущее время: {this.hour}:{this.minute}:{this.second}" +
                                    $"\nФамилия: {this._surname}" +
                                    $"\nОператор: {this._oper}");
        }
        ~Abonent(){}
    }
}