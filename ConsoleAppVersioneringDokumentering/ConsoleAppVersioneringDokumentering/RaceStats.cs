using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    public class RaceStats
    {
        public Driver Driver { get; set; }
        public TimeSpan TotalTime { get; set; }
        public List<TimeSpan> RoundTimes { get; private set; }
        public int Rounds { get; set; }
        public RaceStats()
        {
            RoundTimes = new List<TimeSpan>();
        }
    }
}
