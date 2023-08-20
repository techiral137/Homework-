using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class TextFileReader
    {
        public static string[] txtImport(string fileName)
        {
            try
            {
                string filePath = @"C:\homeWorkfile\" + fileName + ".txt";
                if (System.IO.File.Exists(filePath))
                {
                    string[] textValue = System.IO.File.ReadAllLines(filePath);
                    return textValue;
                }
                else
                {
                    Console.WriteLine("File not found.");
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                return null;
            }
        }
    }
    class FrequentFinder
    {
        public int upperStringFinder(string str)
        {

            int upperFreq = 
            return upperFreq;
        }
    }
}