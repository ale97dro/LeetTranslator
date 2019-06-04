using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    class TranslationService : ITranslationService
    {
        private List<Alphabet> alphabets;

        public TranslationService()
        {
            alphabets = new List<Alphabet>();

            alphabets.Add(AlphabetFactory.LightLeet());
            alphabets.Add(AlphabetFactory.CompleteLeet());
        }

        public IList<Alphabet> Alphabets => alphabets;

        public string ExecuteService(string plainText, ITranslate translator)
        {
            return translator.Translate(plainText);
        }
    }
}
