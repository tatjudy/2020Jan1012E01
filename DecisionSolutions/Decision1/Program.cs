using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision1
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest = -99;
            int first;          //Declare and set default to 0
            int second;         //Declare and set default to 0
            int highest = -99;  //Declared and set to -99
            string message;     //Declared and set to null
            string inputValue;

            System.Console.Write("Enter first number:\t"); //Fully Qualified Method
            //System.Console                               //Fully Qualified Class
            inputValue = Console.ReadLine();
            first = int.Parse(inputValue);

            //Reuse inputValue because previous contents of input value has been stored elsewhere
            System.Console.Write("Enter second number:\t");
            inputValue = Console.ReadLine();
            second = int.Parse(inputValue);

            if (first > second)
            {
                //true path coding block
                //the condition on the if statement is true
                highest = first;
                message = "first";
            }

            else
            {
                //false path coding block
                //the condition on the if statement is false
                highest = second;
                message = "second";
            }//eof
            Console.WriteLine($"First = {first}, Second = {second}," +
                $"the {message} number entered had the higher value: {highest}");
            Console.ReadKey();
        }//eom
    }//eoc
}//eon