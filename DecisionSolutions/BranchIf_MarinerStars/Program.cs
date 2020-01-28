using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchIf_MarinerStars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter your Star Level:\t");

            string inputStarLevel = Console.ReadLine();
            int starLevel = int.Parse(inputStarLevel);
            //int starLevel = 4;        Literal Variable
            string msg = "";
            if (starLevel < 1)
            {
                msg = "Welcom to Holland America Cruise. You have yet to earn special benefits.";
            }
            else if (starLevel < 2)
            {
                msg = "We can receive any of the 1-Star benefits of the Mariner program";
            }
            else if (starLevel < 3)
            {
                msg = "We can receive any of the 2-Star benefits of the Mariner program";
            }
            else if (starLevel < 4)
            {
                msg = "We can receive any of the 3-Star benefits of the Mariner program";
            }
            else if (starLevel < 5)
            {
                msg = "We can receive any of the 4-Star benefits of the Mariner program";
            }
            else
            {
                msg = "We can receive any of the 5-Star benefits of the Mariner program";
            }

            Console.WriteLine(msg);
        }
    }
}
