using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalConditions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Logical Conditions are two or more conditions 
            //separated by a logical operator
            //Relative operator
            //  > >= < <= == !=
            //  Operan operator operan
            //  high > low
            //Logical operators
            // || (or) && (and) ! (not)

            int Age = 6;
            if (Age < 4)
            {
                Console.WriteLine("Too young.");
            }
            else if(Age > 14)
            {
                Console.WriteLine("Too old");
            }
            else
            {
                Console.WriteLine("Welcome to the League");
            }

            //But what about using logical operators
            //Note the operand is repeated for each relative test condition
            // (Age < 4 || Age > 14) incorrect syntax

            //Truth Table
            //Conditions     or  and

            // T T           T    T
            // T F           T    F
            // F T           F    T
            // F F           F    F

            //Summary: && is only true if BOTH relative conditions are true
            //         || is only true if BOTH relative conditions are false

            if (Age < 4 || Age > 14)
            {
                //One does not know if the age is less than or greater than
                Console.WriteLine("Sorry, you are not in the age bracket for this leage.");
            }

            else
            {
                Console.WriteLine("Welcome to the League");
            }
        }
    }
}
