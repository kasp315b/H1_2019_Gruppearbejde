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
        public List<RaceStats> LeaderBoard { get; private set; }
        public int FinalLap { get; private set; }

        public Race()
        {
            Drivers = new List<Driver>();
            LeaderBoard = new List<RaceStats>();
            FinalLap = 80;
        }

        public bool AddDriverToRace(Driver driver)
        {
            Console.Clear();
            var response = false;
            if(driver.Car != null)
            {
                var driverNamesLower = Drivers.Select(s => s.Name.ToLower()).ToList();
                if (!driverNamesLower.Contains(driver.Name.ToLower()))
                {
                    try
                    {
                        Drivers.Add(driver);
                        response = true;
                    }
                    catch (Exception)
                    {
                    }
                }
                PrintDrivers();
            }
            return response;
        }
        private void PrintDrivers()
        {
            foreach (var driver in Drivers)
            {
                Console.WriteLine(driver.Name);
            }
        }
    }
}
