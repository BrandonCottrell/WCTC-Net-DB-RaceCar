using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            var raceTrack = new RaceTrack.RaceTrack(5);
            //just added some cw to space out the laps

            raceTrack.PositionCars();
            Console.WriteLine();
            raceTrack.DriversReady();
            Console.WriteLine();
            raceTrack.StartRace();
            Console.WriteLine();

            for (int i = 0; i < raceTrack.NumberOfLaps; i++)
            {
                raceTrack.AnnouncePositions();
                Console.WriteLine();
            }

            raceTrack.EndRace();
            raceTrack.AnnounceWinners();
        }
    }
}
