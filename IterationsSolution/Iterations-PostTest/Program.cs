using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterations_PostTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //int first, second, highest = -99;
            int number;          //Declare and set default to 0
            const int Two = 2;   //This is a non changable variable
            string inputValue;
            string answer = "";
            //The loop structure demonstrated in this sample is a PostTest
            //Post-Test is also known as Do Until
            //Post-Test executes the code ONCE BEFORE the loop condition is tested
            //After the code has executed, the Post-Test condition is still  for true
            //If the condition is still true the loop code is re-executed
            //If the condition is false the loop terminates and execution continues with the remainder
            //  of the program

            do
            {
                //Within this coding block you are inside your loop
                //This loop will terminate if answer is not Y or y

                //ToDo: place your loop logic here

                System.Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);

                if ((number % Two) == 0)
                {
                    Console.WriteLine($"Your number {number} is even.");
                }

                else
                {
                    Console.WriteLine($"Your number {number} is odd.");
                }//eof

                //ask if the user wishes to continue to play the game
                //give the user an opportunity to exit the loop

                Console.Write("\n\nDo you wish to continue to play the Even or Odd game?");
                answer = Console.ReadLine();
            } while (answer.ToUpper().Equals("Y"));

                //Within this coding block you are inside your loop
                //This loop will terminate if answer is not Y or y

                //ToDo: place your loop logic here

                System.Console.Write("Enter a number:\t");
                inputValue = Console.ReadLine();
                number = int.Parse(inputValue);

                if ((number % Two) == 0)
                {
                    Console.WriteLine($"Your number {number} is even.");
                }

                else
                {
                    Console.WriteLine($"Your number {number} is odd.");
                }//eof

                //ask if the user wishes to continue to play the game
                //give the user an opportunity to exit the loop

                Console.Write("\n\nDo you wish to play the Even or Odd game?");
                answer = Console.ReadLine();

            Console.WriteLine("\n\nYou terminated the loop with your last answer.");
            Console.ReadKey();
        }
    }
}
