using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    public enum BilMaerker { Ford, Volvo, Toyota, Audi, BMW, Suszuki}
    public class Bil
    {
        public int HK { get; private set; }
        public int KM { get; private set; }
        public BilMaerker Brand { get; private set; }
        public string Model { get; private set; }
        public Bil()
        {

        }
        public Bil(string model, BilMaerker brand, int hk)
        {
            Model = model;
            Brand = brand;
            HK = hk;
        }
        

    }
}
