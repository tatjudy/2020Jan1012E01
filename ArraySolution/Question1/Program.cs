using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace Question1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            int[] driverArray = new int[25];
            int logicalsize = ReadAndLoadArray(driverArray, 25);
            int sum = 0;

            for (int index = 0; index < logicalsize; index++)
            {
                sum += driverArray[index];
            }
            if (logicalsize > 0)
            {
                Console.WriteLine($"The average of the {logicalsize} numbers is {(double)sum / (double)logicalsize}.");
            }
            else
            {
                Console.WriteLine($"You have no numbers to calculate an average.");
            }
        }
        static int ReadAndLoadArray(int[] myArray, int physicalsize)
        {
            {
                //Pass to your method the array reference address
                //changes to the array within this method will alter the ORIGINAL
                //      array in the Main() method
                //Physical size is pass by Value (a copy of the original value)
                //Any change to the physical size remaines within this method
                //and DOES NOT affect the original value in Main()

                //REMEMBER ARRAY NAME IS ADDRESS TO THE ARRAY
                int logicalsize = 0; //what you decide to put in



                string Full_Path_File_Name = "";

                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Full_Path_File_Name = fd.FileName;

                string readValue = "";

                StreamReader reader = null;
                try
                {

                    reader = new StreamReader(Full_Path_File_Name);

                    //gets a single row of the file
                    readValue = reader.ReadLine();

                    //if your line that was "read" is null, you have reach the 
                    //   end of the file (eof)
                    while (readValue != null && logicalsize < physicalsize) //logical MUST be less than physical.
                    {
                        myArray[logicalsize] = int.Parse(readValue);
                        logicalsize++;



                        //get the next line
                        readValue = reader.ReadLine();
                    }
                } //eof try
                catch (Exception ex)
                {
                    // .Message holds the error that occured during the processing
                    //     of the code in your try{....}
                    Console.WriteLine($"Error: {ex.Message}");
                }
                finally
                {
                    //this is used if you need to close a data source such as an open file
                    if (reader != null)
                        reader.Close();
                }

                return logicalsize;
            }
        }
    }
}
