using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New4
{
    internal sealed class Ecar : Car //sealed означает что от этого класса наследовать нельзя
    {
        private double evol;

        public Ecar(double evol)
        {
            Evol = evol;
        }
        public Ecar(string name, int tankVol, double fulecons, double evol)
            : base(name, tankVol, fulecons)
        {
            Evol = evol;
        }

        public double Evol { get => evol; set => evol = value; }

        public override double FuelNeeded()
        {
            return (1000-Evol) / 100 * FuleCons;
        }

        public override double MaxSpeed()
        {
            return 300;
        }

        public override double Mileage()
        {
            return (TankVol / FuleCons * 100) + Evol;
        }

        public new void Print()
        {
            Console.WriteLine($"автомоибль {Name}, объемом бака {TankVol} и расходом {FuleCons}л. на 100 км., и запасом хода {Evol}км на электричестве");
        }
    }
}
