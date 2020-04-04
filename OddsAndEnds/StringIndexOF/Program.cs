using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringIndexOF
{
    class Program
    {
        static void Main(string[] args)
        {
            //find the location of a string withing another string
            //use the method .IndexOf();

            //pseudo code (statements)
            //need an original string
            //declare any variables
            //do
            //  get string to look for (method GetString())
            //  find query string in original string
            //  test if found
            //      no: not found message
            //      yes: display index where found in original string 
            //while not to stop

            string myString = "CPSC1012 Fundemental Programming";
            int startpos = 0;
            string inputString = "";
            int indexAt = 0;

            do
            {
                inputString = GetString();
                //findInString.IndexOf(query string, start index position[.length])
                //if the querystring is found in findInString the result will be an index of 0 or more
                //      only the FIRST occurance of the querystring has the index returned
                //if the querystring is NOT found in findInString the result is -1

                //IndexOf is case sensitive, use StringComparison.OrdinalIgnoreCase to avoid case sensitivity

                //indexAt = myString.IndexOf(inputString, startpos, StringComparison.OrdinalIgnoreCase);
                indexAt = myString.ToUpper().IndexOf(inputString.ToUpper(), startpos, StringComparison.OrdinalIgnoreCase);
                if (!inputString.Equals("-1")) //test to see if I quit
                {
                    if (indexAt < 0)
                    {
                        Console.WriteLine($"{inputString} not found in {myString}");
                    }

                    else
                    {
                        Console.WriteLine($"{inputString} found in {myString} at index {indexAt}");
                    }
                }

            } while (!inputString.Equals("-1"));

            Console.ReadKey();

        }

        static string GetString()
        {
            Console.Write("Enter query string\t");
            string input = Console.ReadLine();
            return input;
        }
    }
}
