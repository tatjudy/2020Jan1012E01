using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Implement a temperature converter from Celsius to Fahrenheit
             * 
             * Jan 15, 2020
             */

            //Input: Celsius temperature 
            //      String inputTemp
            //      Double theCelsiusTemperature

            //Output: Fahrenheit temperature
            //      Double theFahrenheitTemperature

            //expression: (ct * 9/5) + 32 = ft
            //check with ct = 0 expect ft = 32
            //check with ct = -40 expect ft = -40
            //check with ct = 100 expect ft = 212

            //Prompt for a temperature
            //.Write keeps your cursor on the same line
            Console.Write("Enter a Celsius Temperature:\t");
            //To obtain the key strokes that the use types (input)
            //Use .Readline()
            //Date comes into the program as a string

            string inputTemp = Console.ReadLine();

            //Converet the string to a double
            //To do this you will use parsing
            //Syntax : datatypeTo.Parse(string)

            double theCelsiusTemperature = double.Parse(inputTemp);
            //Calculation using the conversion expression

            double theFahrenheitTemperature = (theCelsiusTemperature * (9.0d / 5.0d) + 32.0d);

            //Output
            //.Writeline() automatically goes to the next line
            Console.WriteLine($"The Celsius temperature of {theCelsiusTemperature} in" + $" Fahrenheit is {theFahrenheitTemperature}");

            //To ensure that your display stays whether you run without debugging (Ctrl +F5) or running with debugging (F5 or the Start Button) add a .Readline
            Console.ReadLine();
        }
    }
}
