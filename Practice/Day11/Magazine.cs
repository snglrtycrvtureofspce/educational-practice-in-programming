using System;

namespace Day11
{
    public interface IRateAndCopy
    {
        double Rating { get; }
        object DeepCopy();
    }
    public enum Frequency { Weekly, Monthly, Yearly }
    public class Magazine : Edition, IRateAndCopy
    {
        private string _name; // название журнала
        private Frequency _frenk; // частота выхода журнала
        private int _circulation; // тираж
        private DateTime _date; // дата выхода журнала
        private Article[] _list; // список статей в журнале
        private int _size;
        public Magazine(string name, Frequency frenk, int circulation, DateTime create, params Article[] list) // конструктор без параметров 
        {
            this._name = name;
            this._circulation = circulation;
            this._frenk = frenk;
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
                for (var i = 0; i < this._size; i++)
                {
                    sum += _list[i]._rate;
                }
                return sum / _list.Length;
            }
        }

        public override string ToString()
        {
            string text = $"Название журнала: {_name}" +
                          $"\nТираж: {_circulation}" +
                          $"\nДень выхода журнала: {_date:dd:MM:yyyy}" +
                          $"\nЧастота выхода журнала: {this._frenk}" +
                          $"\nСтатьи находящиеся в журнале:\n";
            for (var i = 0; i < _list.Length; i++)
            {
                text += _list[i]._name + "\n";
            }
            return text;
        }

        public virtual string ToShortString()
        {
            return $"Название журнала: {_name}" +
                   $"\nТираж: {_circulation}" +
                   $"\nДень выхода журнала: {_date:dd:MM:yyyy}" +
                   $"\nСредняя оценка статей: {this.Rate}";
        }
        ////////////////////////////////////////////////////
        public object DeepCopy()//override 
        {
            return new Magazine(this._name, this._frenk, this._circulation, this._date, this._list);
        }
        public double Rating
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
        public void AddArticles(params Article[] _list)
        {
            var size = _list.Length;
            Article[] listNew = new Article[size  +  1];
            for (var i = 0; i < _list.Length; i++)
            {
                listNew[i] = _list[i];
            }
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.Write("Введите год рождения: ");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите месяц рождения: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите день рождения:");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите название журнала:");
            string nameArticle = Console.ReadLine(); 
            Console.Write("Введите рейтинг: ");
            int rate = Convert.ToInt32(Console.ReadLine());
            listNew[size  +  1] = new Article(new Person(name,  surname,  new DateTime(year,  month,  day)),  name,  rate);
            _list = listNew;
        }
    }
}