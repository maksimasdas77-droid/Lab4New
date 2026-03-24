using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4New
{
    internal class Airport
    {
        public enum ResultRequest { Success = 1, NoFreeWay = 0, DoubleRequest = -1}
        public string Name { get; set; }

        Runway[] runways;

        public Airport()
        {
            Name = "Минск 2";
            runways = new Runway[1] { new Runway() };
        }

        public Airport(string name, params string[] runwayNames)
        {
            Name = name;
            runways = new Runway[runwayNames.Length];
            for(int i = 0; i < runwayNames.Length; i++)
            {
                runways[i] = new Runway(runwayNames[i], 2000 + i * 10);
            }
        }

        internal ResultRequest hightlightRunway(Plane plane)
        {
            //0 - нет полос
            //1 - выделена полоса
            //-1 - повторный запрос
            foreach(Runway runway in runways)
            {
                if (runway?.plane?.BoardNumber == plane.BoardNumber) return ResultRequest.DoubleRequest;
            }
            for (int i = 0;i < runways.Length; i++)
            {
                if (runways[i]?.plane == null)
                {
                    runways[i].plane = plane;
                    plane.runway = runways[i];
                    return ResultRequest.Success;
                }

            }
            return ResultRequest.NoFreeWay;
        }

        public override string? ToString()
        {
            string result = $"Airport - {Name}. ";
            if (runways != null)
            {
                result += $"Взлетных полос - {runways.Length}\n";
                foreach(Runway runway in runways)
                {
                    result += runway.ToString() + "\n";
                }
            }
            return result;
        }


    }
}
