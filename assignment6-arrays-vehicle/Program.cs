using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace assignment6_arrays_vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] manufacturer = new string[5];
            string[] model = new string[5];
            Double[] cost = new double[5];
           
        for (int x = 0; x < manufacturer.Length; ++x)
            {
                WriteLine("Please enter the the car manufacturer {0}", manufacturer[x]);
                manufacturer[x] = (ReadLine());

                WriteLine("Please enter the model name {0}", model[x]);
                model[x] = (ReadLine());

                WriteLine("Please enter the cost for the vehicle");
                cost[x] = Convert.ToDouble(ReadLine());
            }//ends for x loop

            WriteLine("{0,15}{1,20}{2,10}", "MANUFACTURER", "MODEL", "COST");

            for (int y = 0; y < manufacturer.Length; ++y)
            {
                WriteLine($"{manufacturer[y],15}{model[y],20}{cost[y],10}");
            } //ends y loop 

            double m = cost.Max();
            int p = Array.IndexOf(cost, m);
            WriteLine($"{manufacturer[p]} { model[p]} Had the highest cost!");



            ReadKey();
        }//closes main
    }
}
