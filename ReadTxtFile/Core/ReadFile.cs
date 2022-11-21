using System.IO;

namespace ReadTxtFile.Core
{
    public class ReadFile : IReadFile
    {
        public string[] Read(string path)
        {
            string[] lines = File.ReadAllLines(path);

            return lines;
        }
    }
}
