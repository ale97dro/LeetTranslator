using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    public interface ITranslationService
    {
        string ExecuteService(string plainText, ITranslate translator);
        IList<Alphabet> Alphabets { get; }
    }
}
