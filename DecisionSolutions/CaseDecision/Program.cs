using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseDecision
{
    class Program
    {
        static void Main(string[] args)
        {
            string gradeLetter = "c";
            string percentageRange;

            //A case structure can be used when you have a single
            //argument valye compared to a series of literal values

            // The structure begines with switch(argument value) {....}
            // Within the switch structure you have "cases"
            // A case represents one "if" test against the argument value
            // The case must end with a "break;" command
            // The "break" sends your execution to the end of the switch structure
            // The last case in your switch is a special case called "default"
            // "default" DOES NOT test against a literal value
            // "default" executes if NONE of the previous cases were executed
            // You can have multiple case statements coded for a particular 
            //  case coding block
            // Multiple case statements for a particular case coding block are
            //  implied logical OR (||) tests
            // The case test is a relational equal (==) test

            /*switch (gradeLetter)
            {
                case "a":
                case "A":
                    {
                        // Logic for this particular case
                        percentageRange = "85 - 100";
                        break;
                    }
                case "b":
                case "B":
                    {
                        // Logic for this particular case
                        percentageRange = "70 - 84";
                        break;
                    }
                case "c":
                case "C":
                    {
                        // Logic for this particular case
                        percentageRange = "55 - 69";
                        break;
                    }
                case "d":
                case "D":
                    {
                        // Logic for this particular case
                        percentageRange = "40 - 54";
                        break;
                    }
                case "f":
                case "F":
                    {
                        // Logic for this particular case
                        percentageRange = "0 - 39";
                        break;
                    }
                default:
                    {
                        //The implied test on this case is "None of the above"
                        percentageRange = "Invalid letter grade";
                        break;
                    }
            }//eos*/

            switch (gradeLetter.ToUpper())
            {
                 case "A":
                    {
                        // Logic for this particular case
                        percentageRange = "85 - 100";
                        break;
                    }
                case "B":
                    {
                        // Logic for this particular case
                        percentageRange = "70 - 84";
                        break;
                    }
                case "C":
                    {
                        // Logic for this particular case
                        percentageRange = "55 - 69";
                        break;
                    }
                case "D":
                    {
                        // Logic for this particular case
                        percentageRange = "40 - 54";
                        break;
                    }
                case "F":
                    {
                        // Logic for this particular case
                        percentageRange = "0 - 39";
                        break;
                    }
                default:
                    {
                        //The implied test on this case is "None of the above"
                        percentageRange = "Invalid letter grade";
                        break;
                    }
            }//eos
            Console.WriteLine($"Your grade letter ({gradeLetter}) is {percentageRange}");
            Console.ReadKey(); //When using debugging to stop the auto close of your display

            //Example 2 Print out the month name
            int monNumber = 4;

            //There is a single argument variable.
            //This single argument variable will be tested against multiple constant values
            //The case test is an == test ONLY!!!!

            switch (monNumber)
            {
                case 1:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is January.");
                        break;
                    }



                case 2:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is February.");
                        break;
                    }

                case 3:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is March.");
                        break;
                    }

                case 4:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is April.");
                        break;
                    }

                case 5:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is May.");
                        break;
                    }

                case 6:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is June.");
                        break;
                    }

                case 7:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is July.");
                        break;
                    }

                case 8:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is August.");
                        break;
                    }

                case 9:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is September.");
                        break;
                    }

                case 10:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is October.");
                        break;
                    }

                case 11:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is November.");
                        break;
                    }

                case 12:
                    {
                        //do any logic that is required when monNumber is 1
                        //This could be one line of code ore 10000 lines of code
                        Console.WriteLine("The name of the month is December.");
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Too late in the year to think anymore.");
                        break;
                    }
                    //This logic is done if one of the previous cases 
            }
         }
    }
}
