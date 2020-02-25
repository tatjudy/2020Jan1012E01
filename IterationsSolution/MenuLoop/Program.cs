using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //generic menu setup
            //loop: post-loop
            //loop contents
            //    prompt for menu option
            //    switch with case for each option, default is bad menu option
            //    within the case we will simple output a message
            //decide how to terminate your loop
            string menuOption = "";

            do
            {
                //prompts
                Console.WriteLine("Select a option from the following menu:");
                Console.WriteLine("A) Play Even or Odds");
                Console.WriteLine("B) Do case B");
                Console.WriteLine("C) Do case C");
                Console.WriteLine("X) Exit\n");
                Console.Write("Entry your menu option:\t");
                menuOption = Console.ReadLine();

                switch (menuOption.ToUpper())
                {
                    case "A":
                        {
                            Even_Or_Odds();
                            break;
                        }
                    case "B":
                        {
                            //place the Heads or Tails game in this case
                            //validate that an H or T was entered, if not repeat query for input

                            //Console.WriteLine($"You entered the menu option  of B.\n\n");

                            //Create a method that holds the actual code for this case
                            //The B case will CALL the method to execute
                            //This method is called the calling statement
                            //Calling the method requires your code to use the method name
                            //your program will break to the requested method
                            //When the method has finished, your program will return to the next executable statement after the method call

                            Heads_Or_Tails_Game();

                            break;


                        }
                    case "C":
                        {
                            //the sum of squares
                            //enter postive integer number (validate)
                            //loop n times where n is the integer number (1 to n)
                            //within the loop your calculation is  total += loopnumber * loopnumber
                            //after the loop display your integer number and its sum of squares
                            // entered 4
                            //loop 4 times  1) 1* 1 2) 2* 2 3) 3 * 3 4) 4 * 4 final total = 30
                            Console.WriteLine($"You entered the menu option  of C.\n\n");
                            break;
                        }
                    case "X":
                        {
                            Console.WriteLine($"Thank you. Come again\n\n");
                            break;
                        }
                    default:
                        {
                            //this case acts as a validation for the proper value of a menuOption
                            Console.WriteLine($"Your menu option choice of {menuOption} is incorrect. Try again.\n\n");
                            break;
                        }
                }
            } while (menuOption.ToUpper() != "X");
            Console.ReadKey();
        }//eom


        //the syntax for a method requires accesstype returndatatype MethodName ([list of parameters])
        // {
        //      your method code
        // }

        //accesstype: public or private
        //            protected, internal, have a static reference,

        // returndatatype: if you are returning nothing, use the key word void
        //                 otherwise, return a single value such as int, double, decimal, DateTime, etc.

        //MethodName: continous string of characters which will be used within your program code to reference this coding block
        //            it is best to use a meaningful name
        // [list of parameters] this is a set of local variables that will be used to recieve values from the calling statement
        // a parameter is a set of datatype variablename
        //parameters are separated by using a comma

        static public void Heads_Or_Tails_Game()//posttest
        {
            string inputString = "";
            do
            {
                //validation
                do
                {
                    Console.WriteLine("Enter a H (heades) or T (Tails) or Q (Quit)");
                    inputString = Console.ReadLine();
                } while (!inputString.ToUpper().Equals("H") &&
                       !inputString.ToUpper().Equals("T") &&
                       !inputString.ToUpper().Equals("Q")
                );

                if (inputString.ToUpper().Equals("H")) ||
                        inputString.ToUpper().Equals("T");)
                {
                    //heads or tails
                    if (inputString)
                    {

                    }
                };
                else
                {
                    //quite
                    Console.WriteLine("\n\nThank you. Hope you enjoyed the game.\n\n");
                }
            } while (!inputString.ToUpper().Equals("Q"));
        }//eom Heads_Or_Tails_Game

        static public void Even_Or_Odds()//pretest
        {
            int number = -1;
            string inputString = "";

            while (number != 0)
            {
                //do
                //{
                //    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                //    inputString = Console.ReadLine();
                //} while (!int.TryParse(inputString, out number));

                //condition flag
                //NOTE: it MUST be reset on EACH pass of the OUTER loop
                bool validFlag = false;
                do
                {
                    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                    inputString = Console.ReadLine();
                    //need a test to appropriately set your loop exit test
                    if (int.TryParse(inputString, out number))
                    {
                        //set the flag to an appropriate value to work with your logic
                        validFlag = true;
                    }
                } while (validFlag == false);

                if (number > 0)
                {
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{number} is an even value.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is an odd value.\n\n");
                    }
                }
                else
                {
                    if (number == 0)
                    {
                        Console.WriteLine($"thank you. come again.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is invalid. try again.\n\n");
                    }
                }
            }//eol while

        }//eom Even_Or_Odds
    }
}