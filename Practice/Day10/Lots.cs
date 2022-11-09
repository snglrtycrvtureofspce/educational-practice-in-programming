using System;
using System.Collections.Generic;
using System.Linq;

namespace Day10
{
    public class Lots
    {
        private HashSet<int> _x;
        private HashSet<int> _x2;
        private string _number;
        
        public Lots(HashSet<int> x, HashSet<int> x2)
        {
            this._x = x;
            this._x2 = x2;
        }

        public Lots(string number)
        {
            this._number = number;
        }
        public string number
        {
            set => this._number = value;
            get => this._number;
        }
        public byte this[int index]
        {
            get
            {
                if (index >= 0 && index < this._number.Length)
                {
                    return byte.Parse(this._number[index].ToString());
                }
                return 0;
            }
        }

        public static Lots operator ++(Lots s)
        {
            Lots temp = new Lots(s.ToString());
            return temp;
        }
        public bool IsLots(int p) // принадлежность элемента множеству
        {
            return this._x.Contains(p) ? true : false;
        }

        public bool IsSequenceLots() // является ли множество подмножеством данного
        {
            return (this._x.SequenceEqual(this._x.Intersect(this._x2)) || this._x2.SequenceEqual(this._x.Intersect(this._x2)));
        }

        public bool IsEqualLots() // равны (не равны) ли два множества
        {
            return (this._x.SequenceEqual(this._x.Intersect(this._x2)) == this._x2.SequenceEqual(this._x.Intersect(this._x2)));
        }
        public void AddLots(int num) // добавить элемент в множество
        {
            try
            {
                this._x.Add(num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public void RemoveLots(int num) // удаление элемента из множества
        {
            try
            {
                this._x.Remove(num);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void UnLots() // объединение
        {
            Console.WriteLine(this._x.Union(this._x2));
        }
        public void InterseLots() // пересечение
        {
            Console.WriteLine(this._x.Intersect(this._x2));
        }
        public HashSet<int> DiffAB() // разность A и B
        {
            try
            {
                return new HashSet<int>(this._x.Except(this._x2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public HashSet<int> DiffBA() // разность B и A
        {
            try
            {
                return new HashSet<int>(this._x2.Except(this._x2));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public HashSet<int> DiffLots() // симметрическая разность двух множеств
        {
            try
            {
                return new HashSet<int>(this._x.Except(this._x2).Union(this._x2.Except(this._x)));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        ~Lots(){}
    }
}