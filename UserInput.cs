using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Journey
{
    internal class UserInput
    {
        static void Main (string[] args)
        {
            // asking for the info of the user
            Console.WriteLine("What is your name fellow user?");
            String name = Console.ReadLine();

            Console.WriteLine("What is your age ? ");

            // we use convert to int because we store the value of the user
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old ");

            Console.ReadKey();
        }
    }
}
