using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Query user for a number
            //Validate a number was entered (integer)
            //if a number was entered, check for even/odd
            //Continue unless a 0 was entered, then exit


            //to validate a string to contain a number
            //  use the xxx.TryParse of the number datatype
            //Syntax of .TryParse(string, out variableName)
            //string hold the value to test
            //if the value is good:
            //          The number is automatically placed in your variable
            //          The test returns a boolean true
            //If the value is not good:
            //          No value is placed in your variable
            //          The test returns a boolean false

            int number = -1;
            string inputString = "";

            while (number != 0)
            {
                /*do
                {
                    Console.Write("Enter a positive whole number OR enter 0 to quit.");
                    inputString = Console.ReadLine();


                } while (!int.TryParse(inputString, out number));*/

                //Condition flag
                //Note: it MUST be reset on EACH pass of the OUTER loop

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
                    //DON'T NEED ELSE

                } while (validFlag == false);

                if (number > 0)
                {
                    if(number % 2 == 0)
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
                    if(number == 0)
                    {
                        Console.WriteLine($"Thank you. Come again.\n\n");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is invalid. Try again.\n\n");
                    }
                }
            }
            //Console.WriteLine($"{validFlag} is the value of the validation flag"); IS INVALID BECAUSE validFlag DOES NOT EXIST
            //IN THIS CODING BLOCK

        }
    }
}
