using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteCSV
{
    class Program
    {
        static void Main(string[] args)
        {
            //need the using System.IO
            //need location a) absolute path b) find your special directory path c) FileOpenDialog
            //StreamWriter to handle the outgoing data

            //by default files are replaced
            //you can add a parameter to the StreamWriter that indicates appending or not
            //if the file does not exist it will be created
            StreamWriter writer = new StreamWriter(@"C:\Users\tatju\Documents\GitHub\2020Jan1012E01\files\names.txt", append: true);
            writer.WriteLine("judy tat, CPSC1012, 98");
            writer.Close();

            writer = new StreamWriter(@"C:\Users\tatju\Documents\GitHub\2020Jan1012E01\files\names.txt", append: true);
            writer.WriteLine("shirley ujeset, CPSC1012, 49");
            writer.Close();

            writer = new StreamWriter(@"C:\Users\tatju\Documents\GitHub\2020Jan1012E01\files\names.txt", append: false);
            writer.WriteLine("lowand behold, CPSC1012, 78");
            writer.Close();
        }
    }
}
