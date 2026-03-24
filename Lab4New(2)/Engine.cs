using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New_2_
{
    internal class Engine
    {
        public Engine()
        {
            Name = "СК1154";
        }

        public Engine(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string? ToString()
        {
            return Name;
        }
    }
}
