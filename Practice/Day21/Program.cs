using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Threading;

namespace Day21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Меню программы:" +
                          "\n0 - Выход" +
                          "\n1 - Загрузка данных из XML-файла" +
                          "\n2 - Добавление узла" +
                          "\n3 - Удаление узла" +
                          "\n4 - Сохранение данных в формате XML-файла" +
                          "\nВыберите действие: ");
            var p = Convert.ToInt32(Console.ReadLine());
            XDocument xDoc = XDocument.Load("devices.xml");
            switch (p)
            {
                case 0:
                {
                    Console.WriteLine("Выход из программы...");
                    break;
                }
                case 1:
                {
                    try
                    {
                        Console.WriteLine("Вывод данных из XML-файла: ");
                        Console.WriteLine(xDoc);
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        Console.WriteLine("Файл не найден...");
                        throw;
                    }
                    break;
                }
                case 2:
                {
                    try
                    {
                        Console.Write("Введите название комплектующего: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите страну производства: ");
                        string origin = Console.ReadLine();
                        Console.Write("Введите цену: ");
                        var price = Console.ReadLine();
                        Console.Write("Введите название комплектующего: ");
                        var type = Console.ReadLine();
                        xDoc.Element("Devices").Add(
                            new XElement("Device",
                                new XElement("Name", name),
                                new XElement("Origin", origin),
                                new XElement("Price", 15000),
                                new XElement("Type", new XElement("Item", "non-peripheral")),
                                new XElement("Critical", false)
                            )
                        );
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                    break;
                }
                case 5:
                {
                    List<Device> devices = new List<Device>
                    {
                        new Device
                        {
                            Name = "Keyboard",
                            Origin = "China",
                            Price = 500,
                            Type = new List<string> { "peripheral", "energy=5W", "cooler=yes", "I/O devices", "USB" },
                            Critical = true
                        },
                        new Device
                        {
                            Name = "Monitor",
                            Origin = "Korea",
                            Price = 10000,
                            Type = new List<string>
                                { "non-peripheral", "energy=50W", "cooler=no", "multimedia devices", "HDMI", "VGA" },
                            Critical = false
                        },
                        new Device
                        {
                            Name = "Printer",
                            Origin = "USA",
                            Price = 2000,
                            Type = new List<string>
                                { "peripheral", "energy=30W", "cooler=yes", "I/O devices", "USB", "LPT" },
                            Critical = true
                        },
                        new Device
                        {
                            Name = "Speaker",
                            Origin = "Japan",
                            Price = 3000,
                            Type = new List<string>
                            {
                                "non-peripheral", "energy=20W", "cooler=no", "multimedia devices", "Bluetooth", "3.5mm"
                            },
                            Critical = false
                        },
                        new Device
                        {
                            Name = "Mouse",
                            Origin = "China",
                            Price = 800,
                            Type = new List<string> { "peripheral", "energy=2W", "cooler=no", "I/O devices", "USB" },
                            Critical = true
                        }
                    };

                    xDoc = new XDocument(
                        new XDeclaration("1.0", "utf-8", "yes"),
                        new XElement("Devices",
                            from device in devices
                            select new XElement("Device",
                                new XElement("Name", device.Name),
                                new XElement("Origin", device.Origin),
                                new XElement("Price", device.Price),
                                new XElement("Type", device.Type.Select(t => new XElement("Item", t))),
                                new XElement("Critical", device.Critical)
                            )
                        )
                    );

                    xDoc.Save("devices.xml");
                    break;
                }
            }
        }
    }
}