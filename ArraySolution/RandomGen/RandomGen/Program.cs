using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGen
{
    class Program
    {
        //if declared outside of a method add the keyword static in front of your declaration
        //if declared outside of a method BUT within the class THEN the variable is known to ALL methods WITHOUT having to pass the value as a parameter
        //static Random rnd = new Random()
        static void Main(string[] args)
        {
            //Random is a datatype of class (object)
            //Random is just the definition of the object (describes the object)
            //Random is NOT a physical instance of the object
            //To get a physical instance of the object use the keyword new
            //New is used by any object to create an instance of that object
            //to identify the object instance datatype, add the class name after the keyword new
            //Random is datatype
            //rdn is the variable name of the object instance
            //New is the command keyword to create an object instance
            //Random() is the type of object instance, new is to create

            Random rnd = new Random();
            int number = 0;
            int[] myArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                myArray[i] = rnd.Next(1, 100);
                Console.WriteLine($"index {i} has a value of {myArray[i]}");
            }

            //what is the highest random number generated and the lowest random number generator

            int highest = 0;
            int lowest = 100;

            int loopCounter = 0;
            while (loopCounter < 10)
            {
                if (highest < myArray[loopCounter])
                {
                    highest = myArray[loopCounter]; //New high number
                }

                if (lowest > myArray[loopCounter])
                {
                    lowest = myArray[loopCounter]; //New high number
                }
                loopCounter++;
            }
            Console.WriteLine($"highest value is {highest}");
            Console.WriteLine($"lowest value is {lowest}");
        }

        static void SomeMethod (Random random)
        {

        }
    }
}
