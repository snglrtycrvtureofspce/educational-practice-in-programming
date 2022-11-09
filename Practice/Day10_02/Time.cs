using System;

namespace Day10_02
{
    public class Time
    {
        private int _second, _minute, _hour;
        private DateTime _date1, _date2;
        public DateTime _date = DateTime.Now;
        public Time(){}

        public Time(int second, int minute, int hour)
        {
            this._second = second;
            this._minute = minute;
            this._hour = hour;
        }

        public Time(DateTime date1, DateTime date2)
        {
            this._date1 = date1;
            this._date2 = date2;
        }
        public int second
        {
            set => this._second = value;
            get => this._second;
        }

        public int minute
        {
            set => this._minute = value;
            get => this.minute;
        }
        public int hour
        {
            set => this._hour = value;
            get => this._hour;
        }
        public override string ToString()
        {
            return Convert.ToString($"Информация об объекте:\nЧасы: {this._hour}ч\nМинута: {this._minute}мин\nСекунды: {this._second}сек");
        }
        
        public double DiffSec()
        {
            try
            {
                TimeSpan diff = this._date2.Subtract(this._date1);
                return diff.TotalSeconds;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void LagBeTime(int seconds)
        {
            try
            {
                TimeSpan ts = new TimeSpan(0, 0, seconds);
                Console.WriteLine($"\nВремя отстающее от заданного на заданное количество секунд ({seconds}):\nЧасов: {ts.Hours} \nМинут: {ts.Minutes} \nСекунд: {ts.Seconds}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public int CountSec()
        {
            return (3600 * this._hour) +(60 * this._minute) + this._second;
        }
        ~Time(){}
    }
}