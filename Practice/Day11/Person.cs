using System;

namespace Day11
{
    public class Person
    {
        private string _name;
        private string _surname;
        private DateTime _birthday;
        public Person()
        {
            _name = "Techies";
            _surname = "Pudge";
            _birthday = DateTime.Now;
        }
        public Person(string name, string surname, DateTime birthday)
        {
            _name = name;
            _surname = surname;
            _birthday = birthday;
        }
        public string Name
        {
            set => _name = value;
            get => _name;
        }
        
        public string Surname
        {
            set => _surname = value;
            get => _surname;
        }

        public DateTime Birthday
        {
            set => _birthday = value;
            get => _birthday;
        }
        
        public int BirthdayGetSet
        {
            set => this._birthday = new DateTime(value, this._birthday.Month, this._birthday.Day);
            get => this._birthday.Year;
        }
        public override string ToString()
        {
            return $"Имя: {this._name}" +
                   $"\nФамилия: {this._surname}" +
                   $"\nДень рождения {this._birthday:dd:MM:yyyy}";
        }
        public virtual string ToShortString()
        {
            return $"Имя: {this._name}" +
                   $"\nФамилия: {this._surname}";
        }

        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        public static bool operator ==(Person a, Person b)
        {
            if(a._name == b._name && a._birthday == b._birthday && a._surname == b._surname)
            {
                return true;
            }
            return false;
            
        }
        public static bool operator !=(Person a, Person b)
        {
            if (a._name == b._name && a._birthday == b._birthday && a._surname == b._surname)
            {
                return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return this._name.GetHashCode();
        }
        public override bool Equals(object obj)
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
    }
    
}