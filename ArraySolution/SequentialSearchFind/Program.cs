using Microsoft.Win32; //required for the OpenFileDialog
using System;
using System.Collections.Generic;
using System.IO;  //required to do file i/o
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequentialSearchFind
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {
            //Declare an integer array of 25 elements

            int[] myArray = new int[25];
            //integer variable to indicate the "logical size" of the array
            //the "logical size" referes to the number of elements in the array
            //the declared size (25) is referred to as the physical size
            int logicalsize = 0; //what you decide to put in
            int physicalsize = 25; //the max amt possible


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

            Console.WriteLine($"The number of elements in the array is {logicalsize}");
            for(int loopcounter = 0; loopcounter < logicalsize; loopcounter++)
            {
                Console.WriteLine($"At array index {loopcounter} there is a value of {myArray[loopcounter]}");
            }

            //Sequential Search
            //"Is it there?"

            Console.Write($"Enter a number:\t");
            int searcharg = int.Parse(Console.ReadLine());
            bool found = false;
            int searchindex = 0;

            //condition expression
            //  a) continue to look until you looked at everything
            //  b) continue if not found
            //searchcounter is an index (0 based)
            //logicalsize is a natural count (1 based)

            while (searchindex < logicalsize && !found)
            {
                if (myArray[searchindex] == searcharg)
                {
                    //number was found
                    //stop
                    //searchcounter will be the index of the array location where
                    //  the search argument was first found
                    found = true;
                }
                else
                {
                    //increment to look at the next element in the array
                    searchindex++; //go to next item, increment
                }
            }
            
            if (found)
            {
                Console.WriteLine($"{searcharg} was found at index {searchindex}");
            }
            else
            {
                Console.WriteLine($"{searcharg} was not found in the {logicalsize} array elements.");
            }




            //Count the number of occurances in the array
            searchindex = 0;
            int foundcount = 0;
            found = false;
            //this could also be coded using a for loop BECAUSE 
            //          you are looking at all the elements (actual count)

            //for (int searchindex = 0; searchindex < logicalsize; searchindex++)
            //I DO NOT want to stop when I find the first occurance in the loop


            while (searchindex < logicalsize)
            {
                if (myArray[searchindex] == searcharg)
                {
                    //number was found
                    //stop
                    //searchcounter will be the index of the array location where
                    //  the search argument was first found
                    found = true;
                    foundcount++;

                }
                    //increment to look at the next element in the array
                    searchindex++; //go to next item, increment

            }

            //can do:
            //if (foundcount > 0) then you owuld not need the boolean found flag
            //instead of:

            if (found)
            {
                Console.WriteLine($"{foundcount} occurances of {searcharg} were located in the array");
            }
            else
            {
                Console.WriteLine($"{searcharg} was not found in the {logicalsize} array elements.");
            }
        }
        
    }
}