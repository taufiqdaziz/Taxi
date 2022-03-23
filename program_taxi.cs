using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    class Program
    {

        static void Main(string[] args)
        {
            taxi Taxi = new taxi();

            Taxi.Nama = "Taufiq";
            Taxi.onduty = true;
            Taxi.number = 15;

            Taxi.info();
            Taxi.pup();
            Taxi.dop();

            Console.ReadKey();
        }
    }
}
