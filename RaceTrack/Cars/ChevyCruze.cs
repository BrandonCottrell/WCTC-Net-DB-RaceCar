using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RaceTrack.RaceTrack.Drivers;

namespace RaceTrack.RaceTrack.Cars
{
    public class ChevyCruze : RaceCar
    {
        public ChevyCruze()
        {
            Name = "Chevy Cruze";
            TopSpeed = 90;
        }

        public override void StartEngine()
        {
            Console.WriteLine($"The {Name} starts with its check engine light on!");
        }

        //public override void StopEngine()
        //{
        //    Console.WriteLine($"The {Name} is turned off");
        //}
    }
}
