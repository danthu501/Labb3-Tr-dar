using System;
using System.Threading;

namespace Labb3_Trådar_NY
{
    class Program
    {
        static void Main(string[] args)
        {
            Car Car1 = new Car();
            Car Car2 = new Car();
            Car Info = new Car();


            Thread th1 = new Thread(Car1.StartRaceVolvo);
            Thread th2 = new Thread(Car2.StartRaceToyota);
            

            th1.Start();
            th2.Start();

            Console.WriteLine("För att se statusen i tävlingen tryck på enter");
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

            }
            if (car1.Finished && !car2.Finished)
            {
                Console.WriteLine(car1.CarName + " Vann");

            }
        } 

    }
}
