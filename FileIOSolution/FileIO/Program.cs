using Microsoft.Win32;  //Required for OpenFileDialog
using System;
using System.Collections.Generic;
using System.IO;  //required to do file i/o
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    class Program
    {
        //This is required for your code when using OpenFileDialog
        [STAThread]
        static void Main(string[] args)
        {
            string Full_Path_File_Name = "";
            //you can prompt for the file name

            //Location
            //the file will always be in the same location
            //setup the path name

            //THIS IS ONE WAY
            //string FolderPath = @"c:\Users\jtat2\Documents\GitHub\2020Jan1012E01\FileIOSolution\files\";

            //************************************************************************************************


            //ANOTHER WAY
            //use methods within the software to access the general special folders of your windows file system
            //Documents, Downloads, Pictures, Music

            //This GetFolderPath will return C:\Users\xxxx\the special foldername
            //For the following statement C:\Users\jtat2\Documents
            //string specialpathname = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            //Now, you must add any additional path structure to get to the specific folder within the special folder
            //string FolderPath = specialpathname + @"\GitHub\2020Jan1012E01\FileIOSolution\files\";





            //************************************************************************************************


            // I will assume that the required file will always be found at the root of the course class repository



            //Console.Write("Enter the file name (ex. myfile.txt):\t");
            //string FileName = Console.ReadLine();

            //Full_Path_File_Name = FolderPath + FileName;




            //************************************************************************************************

            //Is there a way to browse for a file
            //Yes, you can call the OpenFileDialog
            //This is the dialog open that you see on your system when you go browsing for a file within an application

            OpenFileDialog fd = new OpenFileDialog();
            fd.ShowDialog();
            Full_Path_File_Name = fd.FileName;

            //setup for reading a file
            //a string variable is required to recieve the data from the file.
            //the string will be filled with one row from your file on each file read

            string readValue = "";

            //use a variable to count the rows in the file (optional)
            int counter = 0;

            //include what is referred to as "User Friendly error handling"
            //This is your try/catch/finally structure
            //the finally portion is ONLY needed if you need to close a connection to a data source

            StreamReader reader = null;

            try
            {
                //in the try is the code you will attempt to execute
                //if an error happens during the execution of the code an Exception is thrown by the system
                //any exception thrown by the system is passed to the catch{} coding block for processing


                //to test the try/catch I will introduce a BAD path name
                //Full_Path_File_Name = @"c:\Users\jtat2\Documents\GitHub\2020Jan1012E01\FileIOSolution\files\bob.txt";




                //add the .Net Framework class that contains the code that will do the read of the file
                //the required i/o class for reading is StreamReader located in the namespace System.IO
                //To attach the reader to the file, you need to pass the full path file name (fully qualified file name) as
                //  an argument to the class while it is being created
                //The reader is referred to as an instance of the class
                //The instance is physically created when the new command is used in conjunction with the class name
                reader = new StreamReader(Full_Path_File_Name);

                //gets a single row of the file
                readValue = reader.ReadLine();

                //if your line was "read" is null, you have reached the end of the file (eof)

                while (readValue != null) //stop when you reach the end of the file
                {
                    counter++;
                    Console.WriteLine($"File line {counter} has a value of {readValue}\n");

                    //get the next line
                    readValue = reader.ReadLine();
                }

            } //eof try

            catch(Exception ex)
            {
                //.Message holds the error that occurred during the processing of the code in your try(.....)
                Console.WriteLine($"Error: {ex.Message}");
            }

            finally
            {
                //This is used if you need to close a data source such as an open file
                reader.Close();
            }

            Console.ReadKey();

        }
    }
}
