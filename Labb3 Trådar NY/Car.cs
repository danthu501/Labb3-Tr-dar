using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Labb3_Trådar_NY
{
    public class Car
    {
        public string CarName { get; set; }
        public decimal Speed = 27.78m;
        public decimal RacingDistance = 1000;
        public decimal Distance = 0;
        public bool Finished = false;



        public void StartRaceToyota()
        {
            CarName = "Toyota";

            int a = 0;
            for (Distance = 0; Distance <= RacingDistance; Distance = Distance + Speed)
            {

                Thread.Sleep(1000);
                a = a + 1;
                if (a == 30)
                {
                    Problems(CarName);
                    a = 0;
                }


                
            }
            Finished = true;
            Finsish(CarName, Finished);
        }

        public void StartRaceVolvo()
        {
            CarName = "Volvo";
            
            int a = 0;
            for (Distance = 0; Distance <= RacingDistance; Distance = Distance + Speed)
            {

                Thread.Sleep(1000);
                a = a + 1;
                if (a == 30)
                {
                    Problems(CarName);
                    a = 0;
                }
            }
            Finished = true;
            Finsish(CarName, Finished);

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
            int Test = new Random().Next(1, 51);
            //Console.WriteLine(Test);

            if (Test <= 1)
            {
                OutOfGas(Carname);
            }
            if (Test >= 49)
            {
                FlatTire(Carname);
            }
            if (Test >= 2 && Test < 5)
            {
                BirdOnWindShield(Carname);
            }
            if (Test >= 10 && Test < 20)
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

        public void Finsish(string car, bool Finished)
        {
            if (Finished)
            {
                Console.WriteLine("{0} Bilen är i mål!", car);
            }
            
            
            

            




        }
    }

}
