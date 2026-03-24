using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New_2_
{


    internal class Driver
    {
        public enum lockcar { Locked = 1, Free = 0 }
        public string Name { get; set; }

        public Car? car { get; set; }

        public Driver() : this("Алексей")
        {
        }
        public Driver(string name)
        {
            Name = name;
        }
        
        public lockcar IslockCar(Car car)
        {
            return this.car == car ? lockcar.Locked : lockcar.Free;
        }

        public override string? ToString()
        {
            return $"Водитель: {Name}" +
                (car == null ? $" Не закреплен за автомобилем" : $"закреплен за автомобилем {car.Name}");
        }
    }
}
