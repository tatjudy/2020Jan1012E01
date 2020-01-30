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
        }
    }
}
