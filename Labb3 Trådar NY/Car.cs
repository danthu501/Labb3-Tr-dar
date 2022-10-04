using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3_Trådar_NY
{
    public class Car
    {
        public string CarName { get; set; }
        public decimal Speed = 27.78m; //Meter per secound 
        public decimal RacingDistance = 500;// Distance in meters
        public decimal Distance = 0;
        public bool Finished = false;



        public void StartRace()
        {
            Started(CarName);
            int a = 0;
            for (Distance = 0; Distance <= RacingDistance; Distance = Distance + Speed)
            {
                
                Thread.Sleep(1000);
                a = a + 1;
                if (a == 3)
                {
                    Problems(CarName);
                    a = 0;
                }
            }
            Finished = true;
        }


        public void OutOfGas(string Car)
        {
            Console.WriteLine(Car + " behöver tanka, står stilla i 30 skeunder");
            Thread.Sleep(30000);
        }

        //2/50 = 4%
        public void FlatTire(string Car)
        {
            Console.WriteLine("{0} behöver byta däck, står still i 20 sekunder", Car);
            Thread.Sleep(20000);
        }
        //5/50 = 10%
        public void BirdOnWindShield(string Car)
        {
            Console.WriteLine("{0} behöver tvättas, står still i 10 sekunder", Car);
            Thread.Sleep(10000);
        }
        //10/50 = 20% 
        public void EngineFaliure(string Car)
        {
            Console.WriteLine("{0} Har motorproblem, bilens hastighet sänks med 1 km/h", Car);
            Speed= Speed - 0.2777778m;
        }

        public void Problems(string Carname)
        {
            int RandomProblemNumber = new Random().Next(1, 51);

            if (RandomProblemNumber <= 1)
            {
                OutOfGas(Carname);
            }
            if (RandomProblemNumber >= 49)
            {
                FlatTire(Carname);
            }
            if (RandomProblemNumber >= 2 && Test < 5)
            {
                BirdOnWindShield(Carname);
            }
            if (RandomProblemNumber >= 10 && Test < 20)
            {
                EngineFaliure(Carname);
            }
            else
            {

            }
        }
        public void Started(string CarName)
        {
            Console.WriteLine("{0} Har startat", CarName);
        }

    }

}
