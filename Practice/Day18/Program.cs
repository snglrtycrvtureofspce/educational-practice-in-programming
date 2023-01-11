using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Day18
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
                    Aeroflot[] flights = new Aeroflot[7];
                    for (int i = 0; i < flights.Length; i++)
                    {
                        Console.Write("Введите пункт назначения для полета " + (i + 1) + ": ");
                        var destination = Console.ReadLine();
                        Console.Write("Введите номер рейса для рейса " + (i + 1) + ": ");
                        var flightNumber = int.Parse(Console.ReadLine());
                        Console.Write("Введите тип самолета для полета " + (i + 1) + ": ");
                        var planeType = Console.ReadLine();

                        flights[i] = new Aeroflot { Destination = destination, FlightNumber = flightNumber, AircraftType = planeType };
                    }
                    Array.Sort(flights, (x, y) => string.Compare(x.Destination, y.Destination));
                    Console.Write("Введите тип самолета, который вы хотите найти: ");
                    string searchType = Console.ReadLine();
                    bool found = false;
                    Console.WriteLine("Рейсы, соответствующие вашему запросу:");
                    foreach (Aeroflot flight in flights)
                    {
                        if (flight.AircraftType == searchType)
                        {
                            Console.WriteLine("Место назначения: {0}, Номер рейса: {1}", flight.Destination, flight.FlightNumber);
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Рейсов с данным типом самолета не найдено.");
                    }
                    // Сериализация XML
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Aeroflot[]));
                    using (FileStream fs = new FileStream("Aeroflot.xml", FileMode.OpenOrCreate))
                    {
                        xmlSerializer.Serialize(fs, flights);
                        Console.WriteLine("Объект сереализован XML");
                    }
                    // Десериализация XML
                    using (FileStream fs = new FileStream("Aeroflot.xml", FileMode.OpenOrCreate))
                    {
                        Aeroflot x = xmlSerializer.Deserialize(fs) as Aeroflot;
                        Console.WriteLine($"Объект десериализован XML \nДата: {x}");
                    }
                    // Сериализация и десериализация JSON
                    using (FileStream fs = new FileStream("Aeroflot.json", FileMode.OpenOrCreate))
                    {
                        string json = JsonConvert.SerializeObject(flights);
                        Console.WriteLine("Объект сереализован JSON");
                        JsonConvert.DeserializeObject(json);
                        Console.WriteLine($"Объект десериализован JSON \nДата: {json}");
                    }
                    break;
                }
                case 2:
                {
                    Circle cirA = new Circle(12, 22);
                    var cir = new Cylinder(12, 22, 24);
                    Console.WriteLine("----------Родитель - Circle, дочерний - Cylinder----------");
                    Console.WriteLine(cirA.ToString());
                    Console.WriteLine("----------Circle - как Circle----------");
                    Console.WriteLine(cir.ToString());
                    Console.WriteLine("--------SET (R), SET (H) + Perimetr()----------");
                    cirA.R = 5;
                    cir.H = 3;
                    Console.WriteLine("Показываем свойства: (R становится 5, H становится 3)");
                    Console.WriteLine("Показываем периметр:");
                    Console.WriteLine("----------Родитель - Circle, дочерний - Cylinder----------");
                    Console.WriteLine(cirA.ToString());
                    Console.WriteLine("----------Circle - как Circle----------");
                    Console.WriteLine(cir.ToString());
                    cirA.Perimeter();
                    Console.WriteLine(cir.ToString());
                    cir.Perimeter();
                    var bs = new List<Figure>
                    {
                        cir,
                        cirA,
                        new Cylinder()
                    };

                    foreach (var item in bs)
                    {
                        Console.WriteLine(item.Perimeter());
                        if (item is Circle) (item as Circle).Perimeter();
                
                    }
                    // Сериализация XML
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Circle));
                    using (FileStream fs = new FileStream("Circle.xml", FileMode.OpenOrCreate))
                    {
                        xmlSerializer.Serialize(fs, cirA);
                        Console.WriteLine("Объект сереализован XML");
                    }
                    // Десериализация XML
                    using (FileStream fs = new FileStream("Circle.xml", FileMode.OpenOrCreate))
                    {
                        Circle x = xmlSerializer.Deserialize(fs) as Circle;
                        Console.WriteLine($"Объект сереализован XML, Дата: {x}");
                    }
                    // Сериализация и десериализация JSON
                    using (FileStream fs = new FileStream("Circle.json", FileMode.OpenOrCreate))
                    {
                        string json = JsonConvert.SerializeObject(cirA);
                        Console.WriteLine($"Дата: {json}");
                        JsonConvert.DeserializeObject(json);
                        Console.WriteLine($"Объект сереализован JSON, Дата: {json}");
                    }
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
