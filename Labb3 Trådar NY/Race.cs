using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3_Trådar_NY
{
    public class Race
    {


        public void Starting()
        {
            Car Car1 = new Car() { CarName = "Toyota" };
            Car Car2 = new Car() { CarName = "Volvo" };

            Thread th1 = new Thread(Car1.StartRace);
            Thread th2 = new Thread(Car2.StartRace);

            Console.WriteLine("För att se statusen i tävlingen tryck på Enter");

            th1.Start();
            th2.Start();

            WriteSatus(Car1, Car2);

            FirstToFinish(Car1, Car2);
        }

        public static void WriteSatus(Car car1, Car car2)
        {

            while (!car1.Finished && !car2.Finished)
            {


                if (Console.KeyAvailable)
                {
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        decimal speed1 = car1.Speed * 3.6m;
                        string Message1 = (car1.CarName + " Har kört: " + Math.Round(car1.Distance) + " meter och har hastigheten: " + Math.Round(speed1) + " km/h");
                        Console.WriteLine(Message1);
                        decimal speed2 = car2.Speed * 3.6m;
                        string Message2 = (car2.CarName + " Har kört: " + Math.Round(car2.Distance) + " meter och har hastigheten: " + Math.Round(speed2) + " km/h");
                        Console.WriteLine(Message2);
                    }
                }
            }

        }
        public static void FirstToFinish(Car car1, Car car2)
        {
            if (!car1.Finished && car2.Finished)
            {
                Console.WriteLine(car2.CarName + " är i mål och Vann");
                while (!car1.Finished)
                {

                }
                if (car1.Finished)
                {
                    Console.WriteLine(car1.CarName + " Är i mål");
                }
            }
            else if (car1.Finished && !car2.Finished)
            {
                Console.WriteLine(car1.CarName + " är i mål och Vann");
                while (!car2.Finished)
                {

                }
                if (car2.Finished)
                {
                    Console.WriteLine(car2.CarName + " Är i mål");
                }
            }
        }
    }
}

