using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    class CompleteLeetTranslator : LeetTranslator
    {
        public CompleteLeetTranslator()
            : base()
        {
            alphabet[65] = alphabet[97] = "4"; //A
            alphabet[67] = alphabet[99] = "["; //B
            alphabet[69] = alphabet[101] = "3"; //E
            alphabet[70] = alphabet[102] = "|="; //F
            alphabet[71] = alphabet[103] = "6"; //G
            alphabet[72] = alphabet[104] = "[-]"; //H
            alphabet[73] = alphabet[105] = "1"; //I
            alphabet[75] = alphabet[107] = "|<"; //K
            alphabet[76] = alphabet[108] = "£"; //L
            alphabet[77] = alphabet[109] = "[V]"; //M
            alphabet[78] = alphabet[110] = "|\\|"; //N
            alphabet[79] = alphabet[111] = "0"; //O
            alphabet[83] = alphabet[115] = "$"; //S
            alphabet[84] = alphabet[116] = "7"; //T
            alphabet[85] = alphabet[117] = "(_)"; //U
            alphabet[87] = alphabet[119] = "VV"; //W
            alphabet[88] = alphabet[120] = "><"; //X
        }
    }
}
