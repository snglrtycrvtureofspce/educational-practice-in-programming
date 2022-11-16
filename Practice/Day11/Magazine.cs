using System;

namespace Day11
{
    public enum Frequency { Weekly, Monthly, Yearly }
    public class Magazine
    {
        private string _name; // название журнала
        private Frequency _fr;
        private int _circulation; // тираж
        private DateTime _date; // дата выхода журнала
        private Article[] _list; 
        int _size;
        private Magazine(string name,/*Frequency fr,*/int circulation,DateTime create, params Article[] list) // конструктор без параметров 
        {
            this._name = name;
            this._circulation = circulation;
            //this._fr = fr;
            this._list = list;
            this._date = create;
            this._size = list.Length;
        }
        private Magazine() // конструктор без параметров 
        {
            //Frequency = ;
            //this._list = fsd
            this._name = "Pip-Boy";
            this._circulation = 555;
        }

        public string Name
        {
            set => this._name = value;
            get => this._name;
        }
        //public Frequency
        public DateTime Date // get/set для даты 
        {
            set => _date = value;
            get => _date;
        }

        public int Circulation
        {
            set => this._circulation = value;
            get => this._circulation;
        }
        public double Rate
        { 
            get
            {
                double sum = 0;
                for (int i = 0; i < this._size; i++)
                {
                    sum += this.Rate;
                }
                return sum / _list.Length;
            }
        }

        public override string ToString()
        {
            return $"Название журнала: {_name}\nТираж: {_circulation}\n"
        }
        

    }
}