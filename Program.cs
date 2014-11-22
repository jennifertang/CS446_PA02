﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    class IO
    {
        int initCT;
        int remCT;
        int beginTime;
        int endTime;
        char type;
        string descriptor;
    }
    class Process
    {
        int initCT;
        int remCT;
        List<IO> ioList = new List<IO>();
        bool finished;
    }
    class Application
    {
        public int PIDNum;
        public int numProc;
        public int procRem;
        public List<Process> ioList = new List<Process>();
        public bool finished;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Declare all variables
            List<string> ourData = new List<string>();  //Temporary list to hold all meta data
            char lastOp = 'S';                          //Stores a value of last operation
            int appIndex = 0, procIndex = 0;            //Application and process index variables
            string dataFile = File.ReadAllText(@"C:\Users\team8\Desktop\exampleFile.txt");

            //Prime the data read in loop-------------------------
            string x = dataFile;
            int index1 = 0, index2 = x.IndexOf(';');
            while( index2 != -1)
            {
                int q = index2 - index1;
                //Console.WriteLine(x.Substring(index1, q));//Debugging
                string temp = x.Substring(index1, q);
                ourData.Add(temp);
                index1 = index2+1;
                index2 = x.IndexOf(';', index2+1);
            }
            string temp2 = x.Substring(index1);
            ourData.Add(temp2);//Adds the final System End
            //End of data read in loop (to a list of strings)-----

            //Begin to store data in proper 
            foreach (string currentLine in ourData)
            {
                //Console.WriteLine(currentLine);//Debugging (Displays all elements stored in our list)
                if (currentLine[0] == 'S' || currentLine[1] == 'S') //Handling System Operation
                {
                    Console.Write('S');
                }
                if (currentLine[0] == 'A' || currentLine[1] == 'A') //Handling Application Operation
                {
                    Console.Write('A');
                }
                if (currentLine[0] == 'P' || currentLine[1] == 'P') //Handling Process Operation
                {
                    Console.Write('P');
                }
                if (currentLine[0] == 'I' || currentLine[1] == 'I') //Handling 
                {
                    Console.Write('I');
                }
                if (currentLine[0] == 'O' || currentLine[1] == 'O')
                {
                    Console.Write('O');
                }
            }

            //Start main program
            Console.ReadKey();

        }
    }
}