using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    public class Driver
    {
        public enum Teams { Red_Bull, Ford, Volvo, Toyota, Audi, BMW, Suzuki, Fiat, KIA, Ferrari, Koenigsegg, Porsche, Hyundai }

        public int Age { get; set; }
        public Car Car { get; set; }
        public string Name { get; set; }
        public Teams Team { get; set; }
    }
}
