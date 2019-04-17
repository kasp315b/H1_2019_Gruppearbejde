using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    public class Driver
    {
        public enum DrivingAbility { Novice, Intermediate, Advanced, Expert}
        public DrivingAbility Ability { get; set; }
        public int Age { get; set; }
        public Car Car { get; set; }
        public string Name { get; set; }
        public Car.CarBrand Team { get; set; }
    }
}
