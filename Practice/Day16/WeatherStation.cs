using System;

namespace Day16
{
    public class WeatherStation
    {
        public int Temperature { get; set; }
        public int Pressure { get; set; }
        public WeatherStation () {}
        public WeatherStation(int temperature, int pressure)
        {
            Temperature = temperature;
            Pressure = pressure;
        }

        public void UpTemp(int temp) // повысить температуру
        {
            this.Temperature += temp;
        }
        public void DownTemp(int temp) // понизить температуру
        {
            this.Temperature -= temp;
        }
        public void UpPressure(int pres) // повысить давление
        {
            this.Pressure += pres;
        }
        public void DownPressure(int pres) // понизить давление
        {
            this.Pressure -= pres;
        }
        public delegate void AccountHandler(string message);

        public event AccountHandler TempBelowZero; // температура ниже нуля
        public event AccountHandler TempAboveZero; // температура выше нуля
        public event AccountHandler PressureDeclining; // давление понижается
        public event AccountHandler PressureRises; // давление повышается

        protected virtual void OnTempBelowZero(string message)
        {
            TempBelowZero?.Invoke(message);
        }

        protected virtual void OnTempAboveZero(string message)
        {
            TempAboveZero?.Invoke(message);
        }

        protected virtual void OnPressureDeclining(string message)
        {
            PressureDeclining?.Invoke(message);
        }

        protected virtual void OnPressureRises(string message)
        {
            PressureRises?.Invoke(message);
        }
    }
}