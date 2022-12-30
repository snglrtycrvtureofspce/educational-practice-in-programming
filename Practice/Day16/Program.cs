using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
                {
                    WeatherStation firstsStation = new WeatherStation(24, 120);
                    firstsStation.Notify += DisplayMessage;
                    firstsStation.UpTemp(50);
                    Console.WriteLine($"Температура: {firstsStation.Temperature}");
                    firstsStation.DownTemp(50);
                    Console.WriteLine(" ");
                    firstsStation.UpPressure(80);
                    Console.WriteLine($"Давление: {firstsStation.Pressure}");
                    firstsStation.DownPressure(80);
                    void DisplayMessage(string message) => Console.WriteLine(message);
                    break;
                }
                case 2:
                {
                    var post = new PostOffice();
                    Abonents.Post1(post, 1, 363);
                    Abonents.Post2(post, 2, -98);
                    Abonents.Post3(post, 4, 23);
                    break;
                }
                default:
                {
                    Console.WriteLine("Exit...");
                    break;
                }
            }
        }

    }
}
