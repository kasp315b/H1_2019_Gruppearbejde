using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    public class Car
    {
        public enum CarBrands{ Ford, Volvo, Toyota, Audi, BMW, Suszuki }
        public int HP { get; private set; }
        public int KM { get; private set; }
        public CarBrands Brand { get; private set; }
        public string Model { get; private set; }
        public Car()
        {

        }
        public Car(string model, CarBrands brand, int hp)
        {
            Model = model;
            Brand = brand;
            HP = hp;
        }
        
        public void Drive()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Wr");
            for (int i = 0; i < HP; i++) sb.Append("o");
            sb.Append("m!");
            Console.WriteLine(sb.ToString());
        }
    }
}
