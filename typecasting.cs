using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Journey
{
    internal class typecasting
    {
        static void main (string[] args)
        {
            //type casting converting string value of a different data type it is useful when we accept a user input useful for (string methods)
            // different data types can do different things

            double a = 3.14;
            //this is an convert to int
            int b = Convert.ToInt32(a);

            //converting to double method
            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;
            Console.WriteLine(b.GetType());

            Console.WriteLine(d.GetType());

            //Converting to string method
            int e = 321;
            String f = Convert.ToString(e);
            Console.WriteLine(f);

            //converting to char
            String g = "$";
            char h = Convert.ToChar(g);
            Console.WriteLine(h);

            Console.ReadKey();
        }
    }
}
