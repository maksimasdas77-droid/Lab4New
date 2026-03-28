using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New3
{
    internal class Circle : Shape
    {
        double r;

        public Circle()
        {
        }

        public Circle(double x, double y, double r) : base(x, y)
        {
            R = r;
        }

        public double R { get => r; set => r = value; }

        public override double Perimeter()
        {
            return 2 * Math.PI * r;
        }

        public override void Print()
        {
            Console.WriteLine($"Окружность с центром ({X};{Y}) и радиусом {R}");
        }

        public override double Square()
        {
            return Math.PI * r * r;
        }
    }
}
