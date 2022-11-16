using System;
using System.Reflection.Emit;

namespace Day11
{
    //public enum Frequency { Weekly, Monthly, Yearly }
    public class Magazine
    {
        private string _name; // название журнала
        // private Frequency _frenk; // частота выхода журнала
        private int _circulation; // тираж
        private DateTime _date; // дата выхода журнала
        private Article[] _list; // список статей в журнале
        int _size;
        public Magazine(string name,/*Frequency frenk,*/int circulation,DateTime create, params Article[] list) // конструктор без параметров 
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
            this._list = new Article[this._size];
            this._name = "Pip-Boy";
            this._circulation = 555;
            this._date = DateTime.Now;
            this._size = _list.Length;
        }

        public string Name
        {
            set => this._name = value;
            get => this._name;
        }
        /*public Frequency
        {
            set
        }*/
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
                    sum += _list[i]._rate;
                }
                return sum / _list.Length;
            }
        }

       /* public Article this[int index]
        {
            get => this.Article[index];
        }*/
        public override string ToString()
        {
            string text = $"Название журнала: {_name}\nТираж: {_circulation}\nДень выхода журнала: {_date:dd:MM:yyyy}\nСтатьи находящиеся в журнале:\n";
            for (int i = 0; i < _list.Length; i++)
            {
                text += _list[i]._name + "\n";
            }
            return text;
        }

        public virtual string ToShortString()
        {
            return $"Название журнала: {_name}\nТираж: {_circulation}\nДень выхода журнала: {_date:dd:MM:yyyy}\nСредняя оценка статей: {this.Rate}";
        }

       /* public void addArticles(params Article[] title)
        {
            
        }*/

    }
}