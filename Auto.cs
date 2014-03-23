using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTO
{
    class Auto
    {
        public string Make;
        public string Model;
        public int Year;
        public string Color;
        public int Mileage;
        public int Speed;
        public int Speedlimit;

        public void Accelerate()

        {

            Speed++;
            if (Speed > Speedlimit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Current speed: " + Speed + "        SLOW DOWN!!!!!");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Current speed: " + Speed);
            }
        
        }

        public void Decelerate()

        {
            Speed--;
            if (Speed > Speedlimit)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Current speed: " + Speed + "        SLOW DOWN!!!!!");
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Current speed: " + Speed);
            }

        }        
    }
}
