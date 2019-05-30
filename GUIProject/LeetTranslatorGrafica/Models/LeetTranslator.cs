using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    public abstract class LeetTranslator : ITranslate
    {
        public const int N_CHAR = 256;

        protected string[] alphabet;

        public LeetTranslator()
        {
            alphabet = new string[N_CHAR];

            for (int i = 0; i < N_CHAR; i++)
                alphabet[i] = Convert.ToChar(i).ToString();
        }

        public virtual string Translate(string plainText)
        {
            StringBuilder s = new StringBuilder();

            foreach (char x in plainText)
                s.Append(alphabet[Convert.ToInt32(x)]);

            return s.ToString();
        }
    }
}
