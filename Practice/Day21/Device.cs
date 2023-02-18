using System.Collections.Generic;

namespace Day21
{
    public class Device
    {
        public string Name { get; set; } // название комплектующего
        public string Origin { get; set; } // страна производства
        public double Price { get; set; } // цена (0 – n рублей).
        public List<string> Type { get; set; }
        /*
        (должно быть несколько) – периферийное либо нет, 
        энергопотребление (ватт), 
        наличие кулера (есть либо нет), 
        группа комплектующих (устройства ввода-вывода, мультимедийные), 
        порты (COM, USB, LPT).
        */
        public bool Critical { get; set; } // критично ли наличие
                                           // комплектующего для
                                           // работы компьютера.
    }
}