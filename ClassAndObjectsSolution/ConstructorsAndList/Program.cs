using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassAndObjects;
using System.IO;
using Microsoft.Win32;

namespace ConstructorsAndList
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //List<T> is an instance class
            //the class will hold different data from a second List<T>
            List<Assessment> StudentList = new List<Assessment>();

            //default Assessment constructor
            Assessment defaultItem = new Assessment();
            //fill it
            defaultItem.FirstName = "don";
            defaultItem.LastName = "welch";
            defaultItem.Mark = 100.0;
            defaultItem.AssessmentName = "default";

            StudentList.Add(defaultItem);

            //Greedy Constructor
            Assessment greedyItem = new Assessment("bob", "harry", "greedie", 35.6, "greed never pays");
            StudentList.Add(greedyItem);

            //foreach (Assessment item in StudentList)
            //{
            //    Console.WriteLine($"Name: {item.LastName}, {item.FirstName}, Assessment {item.AssessmentName} Mark:{item.Mark} Comment: >{item.Comment}<");
            //}

            //for (int i = 0; i < StudentList.Count; i++)
            //{
            //    Console.WriteLine($"Name: {StudentList[i].LastName}, {StudentList[i].FirstName}, Assessment {StudentList[i].AssessmentName} Mark:{StudentList[i].Mark} Comment: >{StudentList[i].Comment}<");
            //}

            Console.WriteLine($"\n\n File reading, List loading, using Assessment class\n");

            ReadAndLoadList(StudentList);

            foreach (Assessment item in StudentList)
            {
                Console.WriteLine($"Name: {item.LastName}, {item.FirstName}, Assessment {item.AssessmentName} Mark:{item.Mark} Comment: >{item.Comment}<");
            }
        }

        static void ReadAndLoadList(List<Assessment> StudentList)
        {
            {

                string Full_Path_File_Name = "";

                OpenFileDialog fd = new OpenFileDialog();
                fd.ShowDialog();
                Full_Path_File_Name = fd.FileName;

                string readValue = "";

                StreamReader reader = null;

                //create a "parking space" for an instance of the class Assessment
                Assessment theInstance = null;
                int column = 0; //this is used to indicate which column on the incoming record


                try
                {
                    reader = new StreamReader(Full_Path_File_Name);

                    //gets a single row of the file
                    readValue = reader.ReadLine();

                    while (readValue != null) //logical MUST be less than physical.
                    {
                        column = 0; //reset for next record
                        //Create a NEW instance for the incoming record
                        theInstance = new Assessment(); //using the default constructor
                        foreach (string item in readValue.Split(','))
                        {
                            switch (column)
                            {
                                case 0:
                                    {
                                        //first column on the record
                                        //get first and last name
                                        //it is one column on the record
                                        //we need to divide the data into 2
                                        //the first and last name are separated by a space
                                        int firstlastspace = item.IndexOf(' ');
                                        theInstance.FirstName = item.Substring(0, firstlastspace);
                                        theInstance.LastName = item.Substring(firstlastspace + 1); //+1 is skip over the first one
                                        break;
                                    }
                                case 1:
                                    {
                                        //second column
                                        theInstance.AssessmentName = item;
                                        break;
                                    }
                                case 2:
                                    {
                                        //third column
                                        theInstance.Mark = double.Parse(item);
                                        break;
                                    }
                                default:
                                    {
                                        //fourth column
                                        theInstance.Comment = item;
                                        break;
                                    }
                            }
                            column++; //increment 1
                        }

                        StudentList.Add(theInstance);

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
            }
        }
    }
}
