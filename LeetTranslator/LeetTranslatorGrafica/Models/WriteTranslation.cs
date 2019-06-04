using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    class WriteTranslation
    {
        public const string FILE_NAME = "translateText.txt";

        public static void WriteOnFile(string text)
        {
            WriteOnFile(text, FILE_NAME);
        }

        public static void WriteOnFile(string text, string path)
        {
            StreamWriter wr = null;
            try
            {
                wr = new StreamWriter(path);
                wr.Write(text);
            }
            finally
            {
                wr.Close();
            }
        }
    }
}
