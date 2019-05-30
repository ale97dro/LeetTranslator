using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    class AlphabetFactory
    {
        public const int N_CHAR = 256;

        //todo: transform into flyweight

        public static Alphabet LightLeet()
        {
            Character[] alphabet = InitializeAlphabet();

            alphabet[65].LeetCharacter = alphabet[97].LeetCharacter = "4";
            alphabet[67].LeetCharacter = alphabet[99].LeetCharacter = "[";
            alphabet[69].LeetCharacter = alphabet[101].LeetCharacter = "3";
            alphabet[71].LeetCharacter = alphabet[103].LeetCharacter = "6";
            alphabet[73].LeetCharacter = alphabet[105].LeetCharacter = "1";
            alphabet[76].LeetCharacter = alphabet[108].LeetCharacter = "£";
            alphabet[79].LeetCharacter = alphabet[111].LeetCharacter = "0";
            alphabet[83].LeetCharacter = alphabet[115].LeetCharacter = "$";
            alphabet[84].LeetCharacter = alphabet[116].LeetCharacter = "7";
            alphabet[85].LeetCharacter = alphabet[117].LeetCharacter = "(_)";

            return new Alphabet("LightLeet", alphabet);
        }

        public static Alphabet CompleteLeet()
        {
            Character[] alphabet = InitializeAlphabet();

            alphabet[65].LeetCharacter = alphabet[97].LeetCharacter = "4"; //A
            alphabet[67].LeetCharacter = alphabet[99].LeetCharacter = "["; //B
            alphabet[69].LeetCharacter = alphabet[101].LeetCharacter = "3"; //E
            alphabet[70].LeetCharacter = alphabet[102].LeetCharacter = "|="; //F
            alphabet[71].LeetCharacter = alphabet[103].LeetCharacter = "6"; //G
            alphabet[72].LeetCharacter = alphabet[104].LeetCharacter = "[-]"; //H
            alphabet[73].LeetCharacter = alphabet[105].LeetCharacter = "1"; //I
            alphabet[75].LeetCharacter = alphabet[107].LeetCharacter = "|<"; //K
            alphabet[76].LeetCharacter = alphabet[108].LeetCharacter = "£"; //L
            alphabet[77].LeetCharacter = alphabet[109].LeetCharacter = "[V]"; //M
            alphabet[78].LeetCharacter = alphabet[110].LeetCharacter = "|\\|"; //N
            alphabet[79].LeetCharacter = alphabet[111].LeetCharacter = "0"; //O
            alphabet[83].LeetCharacter = alphabet[115].LeetCharacter = "$"; //S
            alphabet[84].LeetCharacter = alphabet[116].LeetCharacter = "7"; //T
            alphabet[85].LeetCharacter = alphabet[117].LeetCharacter = "(_)"; //U
            alphabet[87].LeetCharacter = alphabet[119].LeetCharacter = "VV"; //W
            alphabet[88].LeetCharacter = alphabet[120].LeetCharacter = "><"; //X

            return new Alphabet("CompleteLeet", alphabet);
        }

        private static Character[] InitializeAlphabet()
        {
            Character[] alphabet = new Character[N_CHAR];

            for (int i = 0; i < N_CHAR; i++)
                alphabet[i] = new Character(Convert.ToChar(i).ToString());

            return alphabet;
        }
    }
}
