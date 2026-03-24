using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Lab4New.Airport;


namespace Lab4New
{
    internal class Plane
    {
        public Plane()
        {
            BoardNumber = "A007";
        }

        public Plane(string boardNumber)
        {
            BoardNumber = boardNumber;
        }
        public Runway? runway { get; set; }
        public string BoardNumber {  get; set; }

        public ResultRequest LandingRequest(Airport airport)
        {
            return airport.hightlightRunway(this);
        }



        public override string? ToString()
        {
            return $"Самолет, с бортовым номером - {BoardNumber}. " +
                (runway != null ? $"Выделена полоса {runway.Name}" : "Полоса не выделена");
        }
    }
}
