using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AUTO
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto myCar = new Auto();
            myCar.Speed = 0;
            myCar.Make = "Oldsmobile";
            myCar.Model = "Cutlas Supreme";
            myCar.Year = 1988;
            myCar.Color = "Silver";
            myCar.Mileage = 20000;
            myCar.Speedlimit = 50;

            Console.WriteLine(myCar.Make + " " + myCar.Model);
            Console.WriteLine("");

            do
            {

                myCar.Accelerate();

            }

            while (myCar.Speed < 100);

            if (myCar.Speed > myCar.Speedlimit)

                {
                     
                     do
                     {
                         myCar.Decelerate();
                     }

                     while (myCar.Speed > 30);
                }


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("My Current Speed: " + myCar.Speed);          
            Console.ReadLine();

        }
    }
}
