using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ScooterProject
{
    internal class ScooterApp
    {
        public static class Stations
        {
            private static List<Scooter>? TempleMeads { get; set; } = new List<Scooter>();
            private static List<Scooter>? StNicks { get; set; } = new List<Scooter>();
            private static List<Scooter>? CastlePark { get; set; } = new List<Scooter>();

            public static void AddScooterToStation(string station, Scooter scooter)
            {
                if (station == "TempleMeads")
                {
                    TempleMeads!.Add(scooter);
                }
                else if (station == "StNicks")
                {
                    StNicks!.Add(scooter);
                }
                else
                {
                    CastlePark!.Add(scooter);
                }
            }

            public static Scooter[] GetAllScootersAtStation(string station)
            {
                if (station == "TempleMeads")
                {
                    return TempleMeads!.ToArray();
                }
                else if (station == "StNicks")
                {
                    return StNicks!.ToArray();
                }
                else { return CastlePark!.ToArray(); }
            }

        }

        static void Main(string[] args)
        {
            Stations.AddScooterToStation("TempleMeads", new Scooter("Scooter1"));
            Console.WriteLine(Stations.GetAllScootersAtStation("TempleMeads")[0].GetScooterName());
        }
    }
}
