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
            FileInputOutput.OutputSum(Calculus.CalculateSum(fileContents), PATH);
            Console.WriteLine(File.ReadAllText(PATH));
            Console.ReadLine();
        }
    }
}
