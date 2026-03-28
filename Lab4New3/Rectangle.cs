using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New3
{
    internal sealed class Rectangle : Shape
    {
        double w, h;

        public Rectangle(double w, double h)
        {
            W = w;
            H = h;
        }

        public Rectangle(double x, double y, double w, double h) : base(x,y)
        {
            W = w;
            H = h;
        }

        public double W { get => w; set => w = value; }
        public double H { get => h; set => h = value; }

        public override double Perimeter()
        {
           return 2 * (W + H);
        }

        public new void Print()
        {
            base.Print();
            Console.WriteLine($"Прямоугольник в точке ({X};{Y}), шириной {W} и высотой {H}");
        }

        public override double Square()
        {
            return W * H;
        }
    }
}
