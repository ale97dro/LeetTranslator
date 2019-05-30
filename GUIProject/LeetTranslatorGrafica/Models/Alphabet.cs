using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    public class Alphabet
    {
        //private string[] alphabet;

        private List<Character> alphabet;


        public static Alphabet CreateAlphabet()
        {
            Alphabet newAlphabet = new Alphabet();



            return newAlphabet;
        }

        private Alphabet()
        {
            alphabet = new List<Character>(256);
        }
    }
}
