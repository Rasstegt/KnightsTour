using System.Collections.Generic;
using System.IO;

namespace KnightsTour
{
    abstract class FileOutput
    {
        private List<string> output;
        private string filePath, toFile;

        public FileOutput()
        {
            output = new List<string>();
        }

        public void Record(string input)
        {
            output.Add(input);
            toFile = string.Join("\n", output);
        }

        public void WriteToFile()
        {
            File.WriteAllText(Path, toFile);
        }

        public abstract void CreateFile();

        protected string Path { get { return filePath; } set { filePath = value; } }
        
    }
}
