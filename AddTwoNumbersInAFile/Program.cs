using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using AddTwoNumbersInAFile.Classes;

namespace AddTwoNumbersInAFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileContents = FileInputOutput.ReadFileContents();
            string[] fileContentsSplit = StringManipulation.SplitString(fileContents, Separators.GenerateSeparators());
            FileInputOutput.OutputSum(Calculus.CalculateSum(fileContentsSplit));
            Console.WriteLine(File.ReadAllText("../../IOFile.txt"));
            Console.ReadLine();
        }
    }
}
