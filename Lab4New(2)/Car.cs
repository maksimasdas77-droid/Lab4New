using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New_2_
{
    internal class Car
    {
        public string Name { get; set; }
        public Engine Engine { get; set; }
        public int Needpas
        {
            get => needpas;
            set
            {
                if(value > 0) 
                needpas = value;
            }
        }

        private int needpas;

        public Car()
        {
            Name = "Безымянная"; 
            Engine = new Engine();
            Needpas = 1;
        }

        public Car(string name, Engine engine, int needpas)
        {
            Name = name;
            Engine = engine;
            Needpas = needpas;
        }

        public override string? ToString()
        {
            return $"Автомобиль: {Name}, двигатель: {Engine.Name}" ;
        }
    }
}
