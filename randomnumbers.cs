using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Journey
{
    internal class randomnumbers
    {
        static void Main(string[] args)
        {
            //setting up a random number
            Random random = new Random();
            double num = random.NextDouble();
           //int num = random.Next(1, 7) + 100;

           Console.WriteLine(num);

           Console.ReadKey();
        }
    }
}
