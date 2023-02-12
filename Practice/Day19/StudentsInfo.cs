using System;
using System.Collections;
using System.Linq;

namespace Day19
{
    public class StudentsInfo : IComparer
    {
        public int Compare(object x, object y)
        {
            if (object.Equals(x, y)) return 0;
            if (x.Equals(null)) return -1;
            if (y.Equals(null)) return 1;
            return ((Student)x).Number.CompareTo(((Student)y).Number);
        }
    }

    public struct Student
    {
        public string Fio { get; set; }
        public int Number { get; set; }
        public int[] Results;

        public int[] ResExams
        {
            get => Results;
            set
            {
                if (value.Length != 3) throw new ArgumentException(nameof(ResExams));
                Results = value.Take(3).ToArray();
            }
        }

        public Student(string fio, int number, string[] results)
        {
            Fio = fio;
            Number = number;
            try
            {
                Results = results.Select(x => int.Parse(x)).ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;

            }
        }

        public bool IsDone
        {
            get
            {
                /*if (Results.Count(x => x < 3) != 0)
                    return false;
                return true;*/
                return Results.Count(x => x < 3) == 0;
            }
        }

        public override string ToString()
        {
            return $"ФИО: {Fio}, Номер группы: {Number}, Результаты экзаменов: {string.Join(",", Results)};";
        }
    }
}