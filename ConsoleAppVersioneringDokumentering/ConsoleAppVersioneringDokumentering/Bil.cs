using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    public class Bil
    {
        public int HK { get; private set; }
        public int KM { get; private set; }
        public string Brand { get; private set; }
        public string Model { get; private set; }
        public Bil(string model, string brand, int hk)
        {
            Model = model;
            Brand = brand;
            HK = hk;
        }
    }
}
