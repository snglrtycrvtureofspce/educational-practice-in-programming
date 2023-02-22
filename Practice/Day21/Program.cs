using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.XPath;

namespace Day21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                XDocument xDoc = XDocument.Load("devices.xml");
                Console.Write("Меню программы:" +
                          "\n0 - Выход" +
                          "\n1 - Загрузка данных из XML-файла" +
                          "\n2 - Добавление узла" +
                          "\n3 - Удаление узла" +
                          "\n4 - Сохранение данных в формате XML-файла" +
                          "\n5 - Вывод содержимого XML-файла на экран" +
                          "\n6 - Фильтрация по заданному критерию (XPath–язык)" +
                          "\n7 - Поиск, упорядочивание данных по возрастанию/убыванию и группировка согласно заданным критериям." +
                          "\n8 - Задать схему XSD для созданного файла XML." +
                          "\nВыберите действие: ");
            var p = Convert.ToInt32(Console.ReadLine());
            switch (p)
            {
                case 0: // выход
                {
                    Console.Clear();
                    Console.WriteLine("Выход из программы...");
                    return;
                }
                case 1: // загрузка данных из XML-файла
                {
                    XDocument.Load("devices.xml");
                    break;
                }
                case 2: // добавление узла
                {
                    try
                    {
                        Console.Write("Введите название комплектующего: ");
                        string name = Console.ReadLine();
                        Console.Write("Введите страну производства: ");
                        string origin = Console.ReadLine();
                        Console.Write("Введите цену: ");
                        double price = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Введите тип (перефирийное ли): ");
                        string typeFirst = Console.ReadLine();
                        Console.Write("Введите тип (энергопотребление (ватт): ");
                        string typeSecond = Console.ReadLine();
                        Console.Write("Введите тип (наличие кулера (есть либо нет)): ");
                        string typeThird = Console.ReadLine();
                        Console.Write("Введите тип (группа комплектующих (устройства ввода-вывода, мультимедийные)): ");
                        string typeFourth = Console.ReadLine();
                        Console.Write("Введите тип (порты (COM, USB, LPT)): ");
                        string typeFifth = Console.ReadLine();
                        Console.Write("Введите критично ли наличие комплектующего (0/1): ");
                        bool critical = bool.Parse(Console.ReadLine());

                        xDoc.Element("Devices").Add(
                            new XElement("Device",
                                new XElement("Name", name),
                                new XElement("Origin", origin),
                                new XElement("Price", price),
                                new XElement("Type", 
                                    new XElement("Item", typeFirst), 
                                    new XElement("Item", typeSecond), 
                                    new XElement("Item", typeThird), 
                                    new XElement("Item", typeFourth), 
                                    new XElement("Item", typeFifth)),
                                new XElement("Critical", critical)
                            )
                        );
                        xDoc.Save("devices.xml");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                        throw;
                    }
                    break;
                }
                case 3: // удаление узла
                {
                    Console.Write("Введите узел для удаления:");
                    string node = Console.ReadLine();
                    Console.Write("Введите параметр узла:");
                    string parameter = Console.ReadLine();
                    xDoc.Descendants("Device").Where(d => (string)d.Element(node) == parameter).Remove();
                    xDoc.Save("devices.xml");
                    break;
                }
                case 4: // сохранение данных в формате XML-файла
                {
                    try
                    {
                        Console.WriteLine("Данные сохранены в файл devices.xml...");
                        xDoc.Save("devices.xml");
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        Console.WriteLine("Файл не был сохранён...");
                        throw;
                    }
                    break;
                }
                case 5: // вывод содержимого XML-файла на экран
                {
                    try
                    {
                        Console.WriteLine("Вывод данных из XML-файла devices.xml: ");
                        Console.WriteLine(xDoc);
                    }
                    catch (System.IO.FileNotFoundException)
                    {
                        Console.WriteLine("Файл не найден...");
                        throw;
                    }
                    break;
                }
                case 6: 
                /*
                Используя XPath–язык XML-запросов осуществить фильтрацию
                по заданному критерию. 
                Результат запроса вывести на экран и записать в
                новый XML-файл.
                */
                {

                    XPathDocument document = new XPathDocument("devices.xml");

                    XPathNavigator navigator = document.CreateNavigator();

                    Console.Write("Критерии для запроса" +
                                      "\nВведите узел: ");
                    string nodeLine = Console.ReadLine();
                    Console.Write("Введите параметр:");
                    string parameter = Console.ReadLine();
                    XPathNodeIterator nodes = navigator.Select($"//Device[{nodeLine}='{parameter}']");

                    while (nodes.MoveNext())
                    {
                        Console.WriteLine(nodes.Current.OuterXml);
                    }

                    XmlDocument result = new XmlDocument();
                    result.LoadXml("<Devices></Devices>");

                    foreach (XPathNavigator node in nodes)
                    {
                        result.DocumentElement.AppendChild(result.ImportNode(node.UnderlyingObject as XmlNode, true));
                    }

                    result.Save($"{nodeLine}_devices.xml");

                    break;
                }
                case 7:
                    /*
                    Используя LINQ to XML осуществить поиск, 
                    упорядочивание данных по возрастанию/убыванию 
                    и группировку согласно заданным критериям.
                    */
                {
                    Console.Write("Введите страну производства: ");
                    string origin = Console.ReadLine();
                    Console.Write("Введите минимальную цену: ");
                    int minPrice = int.Parse(Console.ReadLine());
                    Console.Write("Введите тип комплектующего: ");
                    string type = Console.ReadLine();
                    Console.Write("Введите критерий упорядочивания (возрастания или убывания): ");
                    string orderBy = Console.ReadLine();
                    Console.Write("Введите критерий группировки (например, порты): ");
                    string groupBy = Console.ReadLine();
                    Console.Write("Введите значение критического комплектующего (true или false): ");
                    bool critical = bool.Parse(Console.ReadLine());

                    XDocument doc = XDocument.Load("devices.xml");

                    var query = from device in doc.Descendants("Device")
                        where (string)device.Element("Origin") == origin &&
                              (int)device.Element("Price") > minPrice &&
                              device.Elements("Type").Any(t => (string)t == type)
                        select device;

                    switch (orderBy) // Упорядочивание элементов
                    {
                        case "возрастания":
                            query = query.OrderBy(d => (int)d.Element("Price"));
                            break;
                        case "убывания":
                            query = query.OrderByDescending(d => (int)d.Element("Price"));
                            break;
                    }

                    // Группировка элементов
                    var groupedQuery = from device in query
                        group device by device.Element(groupBy).Value
                        into g
                        select new XElement("Group", new XAttribute("name", g.Key), g);

                    // Преобразование в XML с корневым элементом Critical
                    XElement root = new XElement("Critical", groupedQuery);
                    root.SetAttributeValue("value", critical.ToString());

                    // Сохранение в файл
                    root.Save("result.xml");

                    Console.WriteLine("Результат сохранен в файл result.xml");
                    break;
                }
                case 8:
                {
                    try
                    {
                        XmlDocument xmlDocument = new XmlDocument();
                        xmlDocument.Load("devices.xml");

                        XmlSchemaSet xmlSchema = new XmlSchemaSet();
                        xmlSchema.Add(null, "devices.xsd");

                        xmlDocument.Schemas = xmlSchema;
                        xmlDocument.Validate((sender, e) =>
                        {
                            if (e.Severity == XmlSeverityType.Error)
                            {
                                Console.WriteLine($"Error: {e.Message}");
                            }
                        });

                        Console.WriteLine("XML-файл успешно проверен по XSD-схеме.");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine($"Ошибка: {e.Message}");
                    }
                    break;
                }
                case 1001:
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

                    xDoc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"),
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
}