using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Win32;

namespace ArrayUtilities
{
    class Program
    {
            [STAThread]
        static void Main(string[] args)
        {
            int[] driverArray = new int[25];
            int[] tempArray = new int[25];
            int logicalsize = ReadAndLoadArray(driverArray, 25); //Calling statement

            //sort ascending the contents of an array
            LoadWorkingArray(driverArray, tempArray);
            sortAscending(tempArray, logicalsize);
            //sort ascending the contents of an array
            LoadWorkingArray(driverArray, tempArray);
            SortDescending(tempArray, logicalsize);

            //find an element in an array
            LoadWorkingArray(driverArray, tempArray);
            FindElement(tempArray, logicalsize, 35);
            FindElement(tempArray, logicalsize, 4);
            FindElement(tempArray, logicalsize, 0);

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

        static void LoadWorkingArray(int[] originalArray, int[] workingArray)
        {
            //Create a physical copy of the array
            workingArray = originalArray;
            int index = 0;

            //foreach loop is a pre-test while
            //it starts with the first item in your collection (array)
            //item is a instance of the collection (array element)
            //the coding block {...} uses the "item" to use the current instance of the collection
            //the loop automatically moves to the next item in your collection
            //the loop automatically stops after the last item in your collection
            //the looop processes the whole collection start to end

            foreach(var item in originalArray)
            {
                workingArray[index] = item;
                index++;

            }
        }

        static void DisplayArray(int[] theArray, int logicalsize)
        {
            Console.WriteLine($"Current values in the array, size {logicalsize}");
            string msg = "";
            for(int i = 0; i < logicalsize; i++)
            {
                msg += theArray[i] + ", ";
            }
            msg = msg.Substring(0, msg.Length - 2);
            Console.WriteLine(msg);
        }

        static void sortAscending(int[] theArray, int logicalsize)
        {
            Console.WriteLine("\n\nArray: Sort Ascending\n");
            DisplayArray(theArray, logicalsize);
            //sort the array
            //use the method .Sort()
            //use .Sort(array) sorts the entire array
            //use .Sort(array, start index value, array length) sorts from element at index "n" for x elements
            Array.Sort(theArray, 0, logicalsize);
            DisplayArray(theArray, logicalsize);
        }

        static void SortDescending(int [] theArray, int logicalsize)
        {
            Console.WriteLine("\n\nArray: Sort Descending\n");
            DisplayArray(theArray, logicalsize);
            //<datatype> identifies the datatype that is being used
            //new create an instance of a class called Comparison<datatype>();
            //to represent any 2 items in your collection (your array) use a placeholder(x,y)
            //=> read as "do the following for x,y
            //x.CompareTo(y) : ascending sort is x less than y
            //y.CompareTo(x) : descending sort is y less than x

            Array.Sort<int>(theArray, new Comparison<int>((x, y) => y.CompareTo(x)));
        }

        static void FindElement(int[] theArray, int logicalsize, int elemtArg)
        {
            Console.WriteLine("\n\nArray: Find Element\n");
            DisplayArray(theArray, logicalsize);

            //.IndexOf(array, searchvalue) searches the entire array
            //.IndexOf(array, searchvalue, startindex, number of elements)
            //if elementArg is found, return the index of that location (first occurance)
            //if elementarg is NOT found, return -1
            int foundindex = Array.IndexOf(theArray, elemtArg, 0, logicalsize);
            if (foundindex < 0)
            {
                //NOT FOUND
                Console.WriteLine($"Your search value {elemtArg} is not found in the array.");
            }

            else
            {
                Console.WriteLine($"Your search value {elemtArg} is found in the array at index {foundindex}.");
                //
            }
        }
    }
}