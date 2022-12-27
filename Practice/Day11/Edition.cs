using System;

namespace Day11
{
    public class Edition
    {
        protected string _name; // название издания
        protected DateTime _date; // дата выхода журнала
        protected int _circulation; // тираж
        public Edition () {}

        public Edition(string name, DateTime date, int circulation)
        {
            this._name = name;
            this._date = date;
            this._circulation = circulation;
        }

        public string Name
        {
            get => this._name;
            set
            {
                if (value.GetType() != typeof(string)) // проверка на тип string
                {
                    throw new Exception("Неверный формат!");
                }
            }
        }
        public DateTime Date { get; set;}

        public int Circulation
        {
            get => this._circulation;
            set
            {
                if (value < 0)
                    throw new Exception("Отрицательное число!");
                else
                    this._circulation = value;
            }
        }
        public virtual object DeepCopy()/////////////////////////
        {
            return new Edition(this._name, this._date, this._circulation);
        }
        public virtual int GetHashCode()//для названия журнала//////////////////
        {
            return _name.GetHashCode();
        }
        public virtual bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static bool operator ==(Edition a, Edition b)
        {
            if (a._name == b._name && a._date == b._date && a._circulation == b._circulation)
            {
                return true;
            }
            return false;

        }
        public static bool operator !=(Edition a, Edition b)
        {
            if (a._name == b._name && a._date == b._date && a._circulation == b._circulation)
            {
                return false;
            }
            return true;
        }
        public override string ToString()
        {
            return $"Название {this._name}" +
                   $"\n Дата {this._date:dd:MM:yyyy}" +
                   $"\nТираж {this._circulation}";
        }
    }
}