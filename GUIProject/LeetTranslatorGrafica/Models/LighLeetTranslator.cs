using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    class LighLeetTranslator : LeetTranslator
    {
        public LighLeetTranslator()
            : base()
        {
            alphabet[65] = alphabet[97] = "4";
            alphabet[67] = alphabet[99] = "[";
            alphabet[69] = alphabet[101] = "3";
            alphabet[71] = alphabet[103] = "6";
            alphabet[73] = alphabet[105] = "1";
            alphabet[76] = alphabet[108] = "£";
            alphabet[79] = alphabet[111] = "0";
            alphabet[83] = alphabet[115] = "$";
            alphabet[84] = alphabet[116] = "7";
            alphabet[85] = alphabet[117] = "(_)";
        }
    }
}
