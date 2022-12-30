using System;
using System.Diagnostics;

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

        public delegate void WeatherStationDelegate(string message);
        public event WeatherStationDelegate Notify;
        public void UpTemp(int temp) // повысить температуру
        {
            Notify?.Invoke($"Температура увеличена.\nТемпература: {temp}");
        }
        public void DownTemp(int temp) // понизить температуру
        {
            if (Temperature <= temp)
            {
                Temperature -= temp;
                Notify?.Invoke($"Температура понижена.\nТемпература: {temp}");
            }
            else
            {
                Notify?.Invoke($"Температура не понижена.\nТемпература: {temp}");
            }
        }
        public void UpPressure(int pres) // повысить давление
        {
            Notify?.Invoke($"Давление увеличено.\nТемпература: {pres}");
        }
        public void DownPressure(int pres) // понизить давление
        {
            if (Temperature <= pres)
            {
                Temperature -= pres;
                Notify?.Invoke($"Давление понижено.\nДавление: {pres}");
            }
            else
            {
                Notify?.Invoke($"Давление не понижено.\nДавление: {pres}");
            }
            
        }
    }
}