using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New_2_
{
    internal class Box
    {
        public string Name { get; set; }

        Gate[] gates;

        public Box()
        {
            Name = "Птор";
            gates = new Gate[1] { new Gate() };
        }

        public Box(string name, params int[] volumes)
        {
            Name = name;

            gates = new Gate[volumes.Length];
            for (int i = 0; i < volumes.Length; i++)
            {
                gates[i] = new Gate(volumes[i]);
            }
        }

        public override string? ToString()
        {
            string result = $"Гараж: {Name} ";
            if (gates != null) 
            {
                result += $"Ворот - {gates.Length}\n";
                foreach(Gate gate in gates)
                {
                    result += gate.ToString() + "\n";
                }
            }
            return result;
        }
    }
}
