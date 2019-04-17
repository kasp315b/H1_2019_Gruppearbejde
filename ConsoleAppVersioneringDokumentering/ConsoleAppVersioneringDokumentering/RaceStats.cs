using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    public class RaceStats
    {
        public bool Started = false;
        public Driver Driver { get; set; }
        public bool Finished { get; set; }
        public int LapProgress { get; set; }
        public int Laps { get; set; }
        public DateTime LapStart { get; set; }
        public List<TimeSpan> LapTimes { get; private set; }
        public TimeSpan TotalTime { get; set; }

        public RaceStats()
        {
            Finished = false;
            LapTimes = new List<TimeSpan>();
        }
    }
}
