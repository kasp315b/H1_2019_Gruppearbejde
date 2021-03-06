﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppVersioneringDokumentering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("En Ændring.");
            //new Program();
            var myRace = new Race(50);
            var addPlayer1 = myRace.AddDriverToRace(new Driver()
            {
                Age = 25,
                Name = "Sven Svenson",
                Team = Car.CarBrand.Audi,
                Car = new Car("A Model", Car.CarBrand.Audi, 230),
                Ability = Driver.DrivingAbility.Expert
            });
            var addPlayer2 = myRace.AddDriverToRace(new Driver()
            {
                Age = 25,
                Name = "Jens Jensen",
                Team = Car.CarBrand.Audi,
                Car = new Car("A Model", Car.CarBrand.Audi, 230),
                Ability = Driver.DrivingAbility.Expert
            });
            var addPlayer3 = myRace.AddDriverToRace(new Driver()
            {
                Age = 25,
                Name = "Lars Larsen",
                Car = new Car("A Model", Car.CarBrand.Audi, 230),
                Ability = Driver.DrivingAbility.Expert
            });
            var addPlayer4 = myRace.AddDriverToRace(new Driver()
            {
                Age = 25,
                Name = "Sven Svenson",
                Team = Car.CarBrand.Audi,
                Car = new Car("A Model", Car.CarBrand.Audi, 230),
                Ability = Driver.DrivingAbility.Expert
            });
            myRace.StartRace();
        }

        //public Program()
        //{
        //    Console.WriteLine("Hello World");

        //    Car myCar = new Car("Punto", Car.CarBrand.Fiat, 90);
        //    var myDriver = new Driver()
        //    {
        //        Age = 25,
        //        Car = myCar,
        //        Name = "Something Something",
        //        Team =  Car.CarBrand.KIA
        //    };
        //    myDriver.Car.Honk();

        //    Console.ReadKey(true);
        //}
    }
}
