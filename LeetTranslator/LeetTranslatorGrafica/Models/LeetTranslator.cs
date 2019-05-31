using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    public class LeetTranslator : ITranslate
    {
        //public const int N_CHAR = 256;

        //protected string[] alphabet;

        protected Alphabet alphabet;

        public LeetTranslator(Alphabet alphabet)
        {
            this.alphabet = alphabet;

            //alphabet = new string[N_CHAR];

            //for (int i = 0; i < N_CHAR; i++)
            //    alphabet[i] = Convert.ToChar(i).ToString();
        }

        public string Translate(string plainText)
        {
            StringBuilder s = new StringBuilder();

            foreach (char x in plainText)
                s.Append(alphabet.GetCharacter(Convert.ToInt32(x)).LeetCharacter);

            return s.ToString();
        }
    }
}
