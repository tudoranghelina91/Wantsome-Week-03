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
            const string PATH = "../../IOFile.txt";

            string fileContents = FileInputOutput.ReadFileContents(PATH);
            string[] fileContentsSplit = StringManipulation.SplitString(fileContents, Separators.GenerateSeparators());
            FileInputOutput.OutputSum(Calculus.CalculateSum(fileContentsSplit), PATH);
            Console.WriteLine(File.ReadAllText(PATH));
            Console.ReadLine();
        }
    }
}
