using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
{
    internal class FileManager
    {
        public static void WriteFile(string path, string content)
        {
            FileInfo fi = new FileInfo(path);

            using(StreamWriter sw = fi.AppendText())
            {
                sw.WriteLine(content);
            }
        }

        public static string ReadFile(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            using(StreamReader sr = fileInfo.OpenText())
            {
                return sr.ReadToEnd();
            }
        }
    }
}
