using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample of pre-test loops
            //While loop
            //for loop

            //code a while loop that breaks the components of a for loop into visible items
            //counter: This will count the number of times through the loop
            //While condition: counter is less than my stop value
            // (stop value is either an upper limit or lower limit)

            //go through the loop several times
            //count the number of even numbers, number of odd numbers
            //after the loop print out the even and odd number totals

            int evenNumber = 0; //If error says unassigned number, make it equal zero
            int oddNumber = 0;
            int endPoint = 7; //sentinal value
            int loopCounter = 1; //to indicate first loop

            string inputValue;
            int number;
            const int TWO = 2;

            while (loopCounter <= 7)
            {
                System.Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);

                if ((number % TWO) == 0)
                {
                    //evenNumber = evenNumber + 1
                    evenNumber++; //running total
                }

                else
                {
                    //oddNumbers = oddNumber + 1;
                    oddNumber += 1; //running total
                }//eof
                //increment the loop counter
                loopCounter++;
            }

            Console.WriteLine($"\nYour even number count is {evenNumber}");
            Console.WriteLine($"Your odd number count is {oddNumber}\n\n");

            //for loop
            //The for loop is a pre-test loop structure
            evenNumber = 0; //reset totals
            oddNumber = 0; //reset totals
            //  initialize          condition           loop increment
            for (int forCounter = 1; forCounter <= endPoint; forCounter++)
            {
                Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);

                if ((number % TWO) == 0)
                {
                    //evenNumber = evenNumber + 1
                    evenNumber++; //running total
                }

                else
                {
                    //oddNumbers = oddNumber + 1;
                    oddNumber += 1; //running total
                }//eof
            }//eol
            Console.WriteLine($"\nYour even number count is {evenNumber}");
            Console.WriteLine($"Your odd number count is {oddNumber}\n\n");

            if (evenNumber < oddNumber)
                Console.WriteLine("do this true line of code");
            else
                Console.WriteLine("do this false line of code");
            //eof
            Console.WriteLine("do this false line of code");
            Console.WriteLine("do this false line of code");
            Console.WriteLine("do this false line of code");
            if (0)
            {
                Console.WriteLine("do this true line of code");
            }
            else
            {
                Console.WriteLine("do this false line of code");
                //eof
                Console.WriteLine("do this false line of code");
                Console.WriteLine("do this false line of code");
                Console.WriteLine("do this false line of code");
            }
        }
    }
}
