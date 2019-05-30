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
            //todo: add the alphabets
            alphabets = new List<Alphabet>();
        }

        public IList<Alphabet> Alphabets => throw new NotImplementedException();

        public string ExecuteService(string plainText, ITranslate translator, bool writeOnFile)
        {
            string translation = translator.Translate(plainText);

            if (writeOnFile)
            {
                WriteTranslation.WriteOnFile(translation);
                Process.Start(WriteTranslation.FILE_NAME);
            }

            return translation;
        }
    }
}
