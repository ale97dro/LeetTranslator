using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica
{
    /// <summary>
    /// Class that represents a translator and perform translations
    /// </summary>
    public class Translator
    {
        private const int N_CHAR= 256;

        private static string[] light_leet_alphabet;
        private static string[] complete_leet_alphabet;

        /// <summary>
        /// Static initialize of the alphabet
        /// It has got two alphabet: light and complete
        /// </summary>
        static Translator()
        {
            light_leet_alphabet = new string[N_CHAR];
            complete_leet_alphabet = new string[N_CHAR];

            for(int i=0;i<N_CHAR;i++)
            {
                light_leet_alphabet[i] = Convert.ToChar(i).ToString();
                complete_leet_alphabet[i] = Convert.ToChar(i).ToString();
            }

            light_leet_alphabet[65] = light_leet_alphabet[97] = "4";
            light_leet_alphabet[67] = light_leet_alphabet[99] = "[";
            light_leet_alphabet[69] = light_leet_alphabet[101] = "3";
            light_leet_alphabet[71] = light_leet_alphabet[103] = "6";
            light_leet_alphabet[73] = light_leet_alphabet[105] = "1";
            light_leet_alphabet[76] = light_leet_alphabet[108] = "£";
            light_leet_alphabet[79] = light_leet_alphabet[111] = "0";
            light_leet_alphabet[83] = light_leet_alphabet[115] = "$";
            light_leet_alphabet[84] = light_leet_alphabet[116] = "7";
            light_leet_alphabet[85] = light_leet_alphabet[117] = "(_)";

            complete_leet_alphabet[65] = complete_leet_alphabet[97] = "4"; //A
            complete_leet_alphabet[67] = complete_leet_alphabet[99] = "["; //B
            complete_leet_alphabet[69] = complete_leet_alphabet[101] = "3"; //E
            complete_leet_alphabet[70] = complete_leet_alphabet[102] = "|="; //F
            complete_leet_alphabet[71] = complete_leet_alphabet[103] = "6"; //G
            complete_leet_alphabet[72] = complete_leet_alphabet[104] = "[-]"; //H
            complete_leet_alphabet[73] = complete_leet_alphabet[105] = "1"; //I
            complete_leet_alphabet[75] = complete_leet_alphabet[107] = "|<"; //K
            complete_leet_alphabet[76] = complete_leet_alphabet[108] = "£"; //L
            complete_leet_alphabet[77] = complete_leet_alphabet[109] = "[V]"; //M
            complete_leet_alphabet[78] = complete_leet_alphabet[110] = "|\\|"; //N
            complete_leet_alphabet[79] = complete_leet_alphabet[111] = "0"; //O
            complete_leet_alphabet[83] = complete_leet_alphabet[115] = "$"; //S
            complete_leet_alphabet[84] = complete_leet_alphabet[116] = "7"; //T
            complete_leet_alphabet[85] = complete_leet_alphabet[117] = "(_)"; //U
            complete_leet_alphabet[87] = complete_leet_alphabet[119] = "VV"; //W
            complete_leet_alphabet[88] = complete_leet_alphabet[120] = "><"; //X
        }

        /// <summary>
        /// This alphabet uses symbols that are admitted by Windows in files' name
        /// </summary>
        /// <param name="text">Text you want to translate</param>
        /// <returns></returns>
        public static string LightLeet(string text)
        {
            StringBuilder s = new StringBuilder();

            foreach (char x in text)
                s.Append(light_leet_alphabet[Convert.ToInt32(x)]);

            return s.ToString();
        }

        /// <summary>
        /// This alphabet can use every symbols
        /// </summary>
        /// <param name="text">Text you want to translate</param>
        /// <returns></returns>
        public static string CompleteLeet(string text)
        {
            StringBuilder s = new StringBuilder();

            foreach (char x in text)
                s.Append(complete_leet_alphabet[Convert.ToInt32(x)]);

            return s.ToString();
        }

        /// <summary>
        /// Write on file the translation
        /// </summary>
        /// <param name="plain_text">Text you want to translate</param>
        /// <param name="translator">Function that allow you to translate</param>
        public static void TranslateOnFile(string plain_text, Func<string, string> translator)
        {
            StreamWriter wr = null;
            try
            {
                wr = new StreamWriter("translateText.txt");
                wr.Write(translator(plain_text));
            }
            finally
            {
                wr.Close();
            }
        }

        /// <summary>
        /// Private constructor. This is a static class
        /// </summary>
        private Translator()
        {

        }
    }
}
