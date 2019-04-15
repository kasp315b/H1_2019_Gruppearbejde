using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        public Program()
        {
            Console.WriteLine("Hello World");

            Car myCar = new Car("Punto", Car.CarBrand.Fiat, 90);
            myCar.Drive();

            Console.ReadKey(true);
        }
    }
}
