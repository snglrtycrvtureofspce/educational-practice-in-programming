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
                    WeatherStation station = new WeatherStation(4, 5);
                    station.PressureDeclining += DisplayMessage;
                    break;
                }
                default:
                {
                    Console.WriteLine("Exit...");
                    break;
                }
            }
            void DisplayMessage(string message) => Console.WriteLine(message);
            void DisplayRedMessage(string message)
            {
                // Устанавливаем красный цвет символов
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                // Сбрасываем настройки цвета
                Console.ResetColor();
            }
        }

    }
}
