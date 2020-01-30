using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuestions
{
    class Program
    {
        static void Main(string[] args)
        {

            //Question 1

            /*Console.Write("Please enter a number\t");
            string inputNum = Console.ReadLine();
            int num = int.Parse(inputNum);
            string msg = "";

            if (num > 0)
            {
                msg = "Positive";
            }
            else if (num < 0)
            {
                msg = "Negative";
            }
            else
            {
                msg = "zero";
            }
            Console.WriteLine(msg);*/

            //Question 2
            Console.Write("Please enter your age:\t");
            string inputAge = Console.ReadLine();
            int age = int.Parse(inputAge);
            string msg = "";

            if (age < 6)
            {
                msg = "There is no cost for admission";
            }
            else if (age > 7)
            {
                msg = "The cost of admission is $9.80";
            }

            else if (age < 17)
            {
                msg = "The cost of admission is $9.80";
            }

            else if (age > 18)
            {
                msg = "The cost of admission is $11.35";
            }
            else if (age < 54)
            {
                msg = "The cost of admission is $11.35";
            }

            Console.WriteLine(msg);
            //Question 3
            //Question 4
        }
    }
}
