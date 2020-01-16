using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // Is a single line comment
            /* is a block
              line
              comment
              group*/
            //C# is a "strongly typed" language
            //  character types: string(""); char('');
            //  whole numerical types: integer and many others
            //  floating numerical types: decimal(28 - 29), double(15 - 16), float(7)
            //  logical type: Boolean

            //Declare variables within Main
            //General grammer(syntax) for declaring a variable is:
            //  accesstype datatype variablename[= value];
            //Special case: within a static class the accesstype is not required
            //By default numerical variables are set to 0
            //Variable in camelCase
            decimal myWeight;
            decimal myHeight;
            decimal BMI = 0.0m;

            //constant unchanging values are declared using the const syntax
            //Const in Pascal Case
            //You CANNOT change the value of a const variable
            const decimal ImperialBMIValue = 703;

            //Assign a value to a value
            //This statement is referred to as an "Assignment" statement
            //Data moves from right to left on an assignment statement
            //On the left side of the = sign will be the recieving storage area
            //On the right side of the = sign will be the data you wish to store

            //Numerical numbers neeed to match the variable datatype
            //Integers have no decimal places
            //Doubles are the default, but may explicitly be typed using a d
            //Decimals require to be explicitly typed using a m
            myWeight = 110;
            myHeight = 1.75m;

            //Math calculate following the accepable rules of arithmetic
            // -assignment
            //() execute within
            // *(Multiplication) /(Division) %(Remainer)
            // +(Addition) -(Subtraction)
            BMI = myWeight / (myHeight * myHeight);
            Console.WriteLine("According to your metric weight of{0:0.0} and height of {1:0.00}: your BMI is {2:0.00}",myWeight, myHeight, BMI);

            //IMPERIAL CALCULATION
            myWeight = 242.5m;
            myHeight = 69.0m;
            BMI = (myWeight * ImperialBMIValue) / (myHeight * myHeight);
            Console.WriteLine($"According to your Imperial weight of{myWeight:0.0} and height of {myHeight:0.00}: your BMI is {BMI:0.00}");

        }   //End of Main
    }
}
