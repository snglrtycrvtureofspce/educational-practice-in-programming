using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Day18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите номер задания: ");
            int p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 1:
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
                    // XML
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(Circle));
                    using (FileStream fs = new FileStream("Circle.xml", FileMode.OpenOrCreate))
                    {
                        xmlSerializer.Serialize(fs, cirA);

                        Console.WriteLine("Объект сереализован xml");
                    }

                    using (FileStream fs = new FileStream("Circle.xml", FileMode.OpenOrCreate))
                    {
                        Circle x = xmlSerializer.Deserialize(fs) as Circle;
                        Console.WriteLine($"дата: {x}");
                    }
                    // Json
                    var crCircle = new Circle();
                    {
                        crCircle.R = 12;
                        crCircle.L = 24;
                    }

                    // Десериализация
                    
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
