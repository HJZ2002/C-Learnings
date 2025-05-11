using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Journey
{
    class Variables
    {
        static void Main(string[] args)
        {
            int x;//declaration
            x = 123;//initializations

            int y = 321;

            int z = x+y;//results

            int age = 21;//whole integer

            double height = 300.5;//decimal number

            bool home = true;//true or false statment

            char symbol = '@';//only for special characters on the keyboard
            String name = "Jaii";

            Console.WriteLine("Hello "+ name);
            Console.WriteLine("Your age is " + age + " Years old ");
            Console.WriteLine("Your height is " + height + "cm");
            Console.WriteLine("Are you home? " +home);
            Console.WriteLine("Your symbol is: " + symbol);

            String username = symbol + name;

            Console.WriteLine("Your username is " +username);
            Console.WriteLine(x);
            Console.WriteLine(y);

            //results
            Console.WriteLine(z);

            Console.ReadKey();

            //end of the code
        }
    }
}
