using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest = -99;
            int number;          //Declare and set default to 0
            const int Two = 2;   //This is a non changable variable
            string inputValue;

            System.Console.Write("Enter a number:\t"); //Fully Qualified Method
            //System.Console                               //Fully Qualified Class
            inputValue = Console.ReadLine();
            number = int.Parse(inputValue);

            if ((number % Two) == 0)
            {
                //true path coding block
                //the condition on the if statement is true
                Console.WriteLine($"Your number {number} is even.");
            }

            else
            {
                //false path coding block
                //the condition on the if statement is false
                Console.WriteLine($"Your number {number} is odd.");
            }//eof
            Console.ReadKey();
        } 
    }
}
