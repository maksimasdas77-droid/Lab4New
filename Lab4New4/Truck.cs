using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New4
{
    internal class Truck : Car
    {
        int capacity;

        public Truck()
        {
        }

        public Truck(string name, int tankVol, double fuleCons, int capacity): base(name, tankVol, fuleCons)
        {
            Capacity = capacity;
        }

        public int Capacity
        {
            get => capacity;
            set
            {
                if(value > 0)
                capacity = value;
            }
        }

        public override double FuelNeeded()
        {
            double weightBonus = (Capacity / 100) * 0.03; // +3% за каждые 100 кг
            double adjustedFuel = FuleCons * (1 + weightBonus);
            return (1000 / 100) * adjustedFuel;
        }

        public override double MaxSpeed()
        {
            return 100-(Capacity / 1000);
        }

        public override double Mileage()
        {
            // Рассчитываем увеличенный расход из-за веса (+3% за каждые 100 кг)
            double fuelIncreaseFactor = 1 + (Capacity / 100) * 0.03;
            double adjustedFuel = FuleCons * fuelIncreaseFactor;

            // Считаем итоговое расстояние
            return (TankVol / adjustedFuel) * 100;
        }

        public override void Print()
        {
            Console.WriteLine($"автомоибль {Name}, объемом бака {TankVol} и расходом {FuleCons}л. на 100 км. и грузоподьемностью {Capacity}кг.");
        }
    }
}
