using System;

namespace Day11
{
    public class Article
    {
        public Person _author;
        public string _name;
        public double _rate;
        public Article(Person author, string name,double rate)
        {
            _author = author;
            _name = name;
            _rate = rate;
        }
        public Article()
        {
            _author = new Person("Kate", "Ivanova", new DateTime(1999, 10, 25));
            _name = "Криминальное чтиво";
            _rate = 10;
        }

        public override string ToString()
        {
            return $"Имя: {this._author.Name}\nФамилия: {this._author.Surname}\nДень рождения {this._author.Birthday:dd:MM:yyyy}\nНазвание статьи: {this._name}\nРейтинг статьи: {this._rate}";
        }


    }
}