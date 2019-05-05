using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddTwoNumbersInAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize sum variable
            int s = 0;

            // read all file contents into a string
            string fileContents = File.ReadAllText("../../IOFile.txt");

            // declare separators in a string for escaping unwanted characters like letters and symbols
            string separator = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ~!@#$%^&*(),./;'\\[]-=_+<>?:\"|{}\t\n\r^ ";

            // convert separator string to array
            char[] separatorArr = separator.ToCharArray();

            // split the string with separators to retrieve only the numbers as a string in a string array
            string[] fileContentsSplit = fileContents.Split(separatorArr, StringSplitOptions.RemoveEmptyEntries);

            // loop through each element of the new string array
            foreach (string numberString in fileContentsSplit)
            {
                // convert each string to an integer and add it to sum
                s += Convert.ToInt32(numberString);
            }

            // Write output to file (sum)
            File.AppendAllText("../../IOFile.txt", "\n\n");
            File.AppendAllText("../../IOFile.txt", "The sum of every number inside the text: \n\n");
            File.AppendAllText("../../IOFile.txt", s.ToString());

            // Print text content to screen
            Console.WriteLine(File.ReadAllText("../../IOFile.txt"));

            Console.ReadLine();
        }
    }
}
