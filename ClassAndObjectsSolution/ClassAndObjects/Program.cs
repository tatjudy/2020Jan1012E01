using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create an instance of my assessment class
            Assessment myInstance = new Assessment();

            //use the instance
            //Which action in the property is being used on the following statements?
            //set (instance is on the "left side" of an assignent
            myInstance.FirstName = "judy";
            myInstance.LastName = "tat";
            myInstance.AssessmentName = "core portfolio 5";
            myInstance.Mark = 99.9;

            //static or Instance?
            //static: using the class name without creating the class
            //get (instance is on the "right side" of the statement
            Console.WriteLine($"first name: {myInstance.FirstName} last name: {myInstance.LastName}" + $"Assessment {myInstance.AssessmentName} mark: {myInstance.Mark}" +$"comments: {myInstance.Comment}");
        }
    }
}
