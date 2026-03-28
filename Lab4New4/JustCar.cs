using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New4
{
    internal class JustCar : Car
    {
        public JustCar()
        {
        }

        public JustCar(string Name, int Vol, double Cons) : base(Name, Vol, Cons) 
        {
        }

        public override double FuelNeeded()
        {
            return 1000 / 100 * FuleCons;
        }

        public override double MaxSpeed()
        {
            return 100;
        }

        public override double Mileage()
        {
            return TankVol / FuleCons * 100;
        }
    }
}
