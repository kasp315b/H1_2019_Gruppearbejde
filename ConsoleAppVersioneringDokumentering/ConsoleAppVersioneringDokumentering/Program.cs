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
            var myDriver = new Driver()
            {
                Age = 25,
                Car = myCar,
                Name = "Something Something",
                Team =  Car.CarBrand.KIA
            };
            myDriver.Car.Honk();

            Console.ReadKey(true);
        }
    }
}
