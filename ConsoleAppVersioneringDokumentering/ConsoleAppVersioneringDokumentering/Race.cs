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

        public bool AddDriverToRace(Driver driver)
        {
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
            }
            return response;
        }
    }
}
