using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static Lab4New_2_.Box;

namespace Lab4New_2_
{
    internal class Box
    {
        public enum ResultRequest { Success = 1, NoFreeWay = 0, DoubleRequest = -1 }
        public string Name { get; set; }

        Gate[] gates;

        public Box() : this("Птор", 3)   //вызываем основной конструктор
        {
            // здесь больше ничего не нужно
        }

        public Box(string name, params int[] volumes)
        {
            Name = name;

            // если volumes пустой — создаём ворота по умолчанию
            if (volumes.Length == 0)
                volumes = new int[] { 3 };   //значение по умолчанию

            gates = new Gate[volumes.Length];

            for (int i = 0; i < volumes.Length; i++)
            {
                gates[i] = new Gate(volumes[i]);
                gates[i].Box = this;         
            }
        }
        internal ResultRequest hightlightRunway(Car car)
        {
            //0 - нет полос
            //1 - выделена полоса
            //-1 - повторный запрос
            foreach (Gate gate in gates)
            {
                if (gate?.carinside?.Name == car.Name) return ResultRequest.DoubleRequest;
            }
            for (int i = 0; i < gates.Length; i++)
            {
                if (gates[i].carinside == null)
                {
                    gates[i].carinside = car;
                    //car.box = this;
                    car.Gate = gates[i];

                    return ResultRequest.Success;
                }

            }
            return ResultRequest.NoFreeWay;
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
