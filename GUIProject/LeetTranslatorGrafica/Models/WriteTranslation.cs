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
            StreamWriter wr = null;
            try
            {
                wr = new StreamWriter(FILE_NAME);
                wr.Write(text);

                //OpenTranslation();
            }
            finally
            {
                wr.Close();
            }
        }

        //private static void OpenTranslation()
        //{
        //    Process.Start(FILE_NAME);
        //}
    }
}
