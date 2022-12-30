using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikaden14
{
    internal abstract class Figure : IComparable
    {
        abstract public double Ploshca();

        abstract public double Perimetr();

        abstract public void Show();

        public int CompareTo(object obj)
        {
            Figure p = obj as Figure;
            if (p != null)
                return this.Ploshca().CompareTo(p.Ploshca());
            else
                throw new Exception("Невозможно сравнить два объекта");
        }

    }
}