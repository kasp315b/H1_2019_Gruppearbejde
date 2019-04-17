using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    public class Race
    {
        private Random rand = new Random();
        public DateTime Start { get; private set; }
        public List<Driver> Drivers { get; private set; }
        public List<RaceStats> LeaderBoard { get; private set; }
        public int FinalLap { get; private set; }

        public Race()
        {
            Drivers = new List<Driver>();
            LeaderBoard = new List<RaceStats>();
            FinalLap = 80;
        }
        public Race(int laps)
        {
            Drivers = new List<Driver>();
            LeaderBoard = new List<RaceStats>();
            FinalLap = laps;
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
                        ResetLeaderBoard();
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
        private void ResetLeaderBoard()
        {
            LeaderBoard.Clear();
            foreach (var driver in Drivers)
            {
                var racer = new RaceStats() { Driver = driver };
                LeaderBoard.Add(racer);
            }
        }
        private bool Racing(RaceStats driver)
        {
            var response = false;

            int progress = 0; ;
            switch (driver.Driver.Ability)
            {
                case Driver.DrivingAbility.Novice:
                    progress = rand.Next(10, 50);
                    break;
                case Driver.DrivingAbility.Intermediate:
                    progress = rand.Next(30, 80);
                    break;
                case Driver.DrivingAbility.Advanced:
                    progress = rand.Next(50, 120);
                    break;
                case Driver.DrivingAbility.Expert:
                    progress = rand.Next(100, 250);
                    break;
                default:
                    break;
            }
            if (!driver.Started)
            {
                driver.Started = true;
                driver.LapStart = DateTime.Now;
            }
            driver.LapProgress = driver.LapProgress + progress;

            if (driver.LapProgress >= 1000)
            {
                driver.Laps++;
                driver.LapTimes.Add(DateTime.Now - driver.LapStart);
                driver.LapStart = DateTime.Now;
                driver.LapProgress = driver.LapProgress - 100;
            }

            if (driver.Laps > FinalLap)
            {                
                driver.TotalTime = DateTime.Now - Start;
                driver.Finished = true;
                response = true;
            }

            return response;
        }
        public void StartRace()
        {
            if(Start == new DateTime(1,1,1))
                Start = DateTime.Now;
            foreach (var raceCompetitor in LeaderBoard)
            {
                if (!raceCompetitor.Finished)
                {
                    Racing(raceCompetitor);
                }
            }
            var notFinished = LeaderBoard.Where(s => s.Finished == false).ToList();
            if (notFinished.Count == 0)
            {
                Console.WriteLine(DateTime.Now - Start);
                PrintLeaderboard();
                Console.WriteLine();
                Console.WriteLine("Finished");
                foreach (var racer in LeaderBoard)
                {
                    Console.WriteLine("{0}: {1}",racer.Driver.Name, racer.TotalTime);
                }
            }
            else
            {
                Thread.Sleep(100);
                PrintLeaderboard();
                StartRace();
            }
        }
        private void PrintLeaderboard()
        {
            Console.Clear();
            foreach (var racer in LeaderBoard)
            {
                if(!racer.Finished)
                    Console.WriteLine("{0}  |  {1}", racer.Driver.Name, racer.Laps);
                else
                    Console.WriteLine("{0}  |  Finished", racer.Driver.Name);

            }
        }
    }
}
