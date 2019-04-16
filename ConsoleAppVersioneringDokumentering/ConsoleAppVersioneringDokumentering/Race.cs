using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    public class Race
    {
        public List<Driver> Drivers { get; private set; }
        public List<RaceStats> RaceBoard { get; private set; }
    }
}
