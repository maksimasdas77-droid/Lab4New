using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New
{
    internal class Runway
    {
        public Runway() : this("Ромашка", 1500)
        {
        }

        public Runway(string name, int leght)
        {
            Name = name;
            Leght = leght;
        }

        public string Name { get; set; }

        public int Leght { get; set; }
        public Plane? plane { get; set; } 

        public override string? ToString()
        {
            return $"Взлетная полоса - {Name}, длинной - {Leght} м. " +
                (plane != null ? $"Выделена самолету {plane.BoardNumber}" : "Свободна" );
        }
    }
}
