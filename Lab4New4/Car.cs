using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New4
{
    internal abstract class Car
    {
        protected string Name { get; set; }
        private int tankVol;
        private double fuleCons;

        protected int TankVol { get => tankVol; set => tankVol = value; }
        protected double FuleCons { get => fuleCons; set => fuleCons = value; }

        protected Car(string name, int tankVol, double fuleCons)
        {
            Name = name;
            TankVol = tankVol;
            FuleCons = fuleCons;
        }

        protected Car(string name, int tankVol)
            : this(name, tankVol, 10)
        {
        }

        protected Car()
            : this("Машина", 60, 10)
        {
        }

        public abstract double Mileage();
        public abstract double FuelNeeded();
        public abstract double MaxSpeed();

        public virtual void Print()
        {
            Console.WriteLine($"автомоибль {Name}, объемом бака {TankVol} и расходом {FuleCons}л. на 100 км.");
        }
    }
}
