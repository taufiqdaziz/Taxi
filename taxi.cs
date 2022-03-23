using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    public class taxi
    {
        public int number { get; set; }
        public string Nama { get; set; }
        public bool onduty { get; set; }

        private string ondutys()
        {
            return onduty ? "yes" : "no";
               
        }


        public void info()
        {
            Console.WriteLine("Driver Name : {0}", Nama);
            Console.WriteLine("On Duty : {0}", ondutys());
            Console.WriteLine("Number of Passenger : {0}", number);
        }
        // pup = pick up passanger
        public void pup()
        {
            Console.WriteLine("{0} sedang menjemput penumpang", Nama);
        }
        // dop = drop of passanger
        public void dop()
        {
            Console.WriteLine("{0} selesai mengantar penumpang", Nama);
        }
    }
}
