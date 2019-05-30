using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    public class Character
    {
        public Character(string originalCharacter, string leetCharacter)
        {
            this.OriginalCharacter = originalCharacter;
            this.LeetCharacter = leetCharacter;
        }

        public Character(string character)
            : this(character, character)
        {

        }

        public string OriginalCharacter { get; }

        public string LeetCharacter { get; set; }
    }
}
