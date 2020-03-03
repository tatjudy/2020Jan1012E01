using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arrays are a fixed size collection of a single data type
            //Array names hold an internal address to the actual physical memory location of the array storage area
            //A single item in the array is called the array element
            //Declaring an array requires knowing the 
            //  a)physical size
            //  b)the elements to initialize the array

            //a) array declared by physical size
            int[] physicallyDeclared = new int[7];

            //b) the elements to initialize the array
            //The number of values specifies the physical array size
            //each supplied value is placed within the array consecutively
            //the datatype after the new is optional BUT the value given MUST match the recieving array declaration type
            int[] diceValue = new int[] { 1, 2, 3, 4, 5, 6 };

            //The physically declared array has an initial default value for each element depending on the system default value of the
            //  array datatype
            int pDSize = 7;

            for (int index = 0; index < pDSize; index++)
            {
                Console.WriteLine($"physicallyDeclared array element {index + 1} located at index {index} has a value of {physicallyDeclared[index]}");
            }

            int dVSize = diceValue.Length;

            for (int index = 0; index < dVSize; index++)
            {
                Console.WriteLine($"diceValue array element {index + 1} located at index {index} has a value of {diceValue[index]}");
            }

            Console.ReadKey();

        }
    }
}
