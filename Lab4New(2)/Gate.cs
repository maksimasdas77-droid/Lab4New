using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4New_2_
{
    internal class Gate
    {
        private static int _counter = 0;
        private int numbergate;
        private int volume;

        public Car? carinside {  get; set; }
      
        public int Numbergate => numbergate;

        public int Volume
        {
            get => volume;
            set
            {
                if(value > 0 && value < 10)
                volume = value;
            }
        }

        public Gate() : this(3)
        {
        }


        public Gate(int volume)
        {
            _counter++;
            numbergate = _counter;
            Volume = volume;
        }
        public override string ToString()
        {
            return carinside == null
                ? $"Ворота номер {Numbergate} (объём {Volume}) — свободны"
                : $"Ворота номер {Numbergate} (объём {Volume}) — заняты: {carinside.Name}";
        }
    }
}
