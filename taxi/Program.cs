using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taxi_app
{
    internal class Program
    {
        static void Main()
        {
            Taxi taxi = new Taxi();

            Console.WriteLine("--- DATA DRIVER TAXI ---");
            Console.WriteLine();

            taxi.DriverName = "Yopiezhar";
            taxi.OnDuty = true;
            taxi.NumPassanger = 10;

            taxi.TaxiInfo();
            taxi.PickUpPassanger();
            taxi.DropOffPassanger();

            Taxi taxi2 = new Taxi();

            Console.WriteLine();

            taxi2.DriverName = "Zhabima";
            taxi2.OnDuty = false;
            taxi2.NumPassanger = 0;

            taxi2.TaxiInfo();
            taxi2.PickUpPassanger();
            taxi2.DropOffPassanger();

            Console.ReadKey();
        }
    }
}
