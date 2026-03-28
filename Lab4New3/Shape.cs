using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New3
{
    internal abstract class Shape
    {
        protected double x, y; //точка привязки

        public Shape(double x, double y)
        {
            X = x;
            Y = y;
        }

        protected Shape():this(0,0)
        {
        }

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public abstract double Perimeter();

        public abstract double Square();

        public virtual void Print()
        {
            Console.WriteLine($"Фигура в точке {X};{Y}");
        }
    }
}
