using System;
using System.Runtime.InteropServices;

namespace Day09
{
    public class Time
    {
        private int _hour, _minute, _second;
        public Time() { }
        public Time(int hour, int minute, int second)
        {
            this._hour = hour;
            this._minute = minute;
            this._second = second;
        }
        public int hour
        {
            set => this._hour = value;
            get => this._hour;
        }
        public int minute
        {
            set => this._minute = value;
            get => this._minute;
        }
        public int second
        {
            set => this._second = value;
            get => this._second;
        }
        public int count_minutes ()
        {
            return ((3600 * this._hour) + (60 * this._minute) + this._second) / 60;
        }

        public int minus_minutes()
        {
            return (((3600 * this._hour) + (60 * this._minute) + this._second) / 60) - 10;
        }
        public override string ToString()
        {
            return Convert.ToString($"Информация об объекте:\nЧасы: {this._hour}ч\nМинута: {this._minute}мин\nСекунды: {this._second}сек");
        }
        ~Time()
        {
            Console.WriteLine("Объект был уничтожен");
        }
    }
}