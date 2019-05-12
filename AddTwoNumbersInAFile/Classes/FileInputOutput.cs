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
        public static string ReadFileContents(string path)
        {
            // read all file contents into a string
            return File.ReadAllText(path);
        }

        public static void OutputSum(int s, string path)
        {
            File.AppendAllText(path, "\n\n");
            File.AppendAllText(path, "The sum of every number inside the text: \n\n");
            File.AppendAllText(path, s.ToString());
        }
    }
}
