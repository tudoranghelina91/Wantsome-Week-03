using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddTwoNumbersInAFile.Classes
{
    class FileInputOutput
    {
        public static string ReadFileContents()
        {
            // read all file contents into a string
            return File.ReadAllText("../../IOFile.txt");
        }

        public static void OutputSum(int s)
        {
            File.AppendAllText("../../IOFile.txt", "\n\n");
            File.AppendAllText("../../IOFile.txt", "The sum of every number inside the text: \n\n");
            File.AppendAllText("../../IOFile.txt", s.ToString());
        }
    }
}
