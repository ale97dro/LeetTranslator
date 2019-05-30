using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    public class Alphabet
    {
        private List<Character> characters;

        public Alphabet(List<Character> characters)
        {
            this.characters = characters;
        }

        public Alphabet(Character[] characters)
        {
            this.characters = characters.ToList();
        }

        public Character GetCharacter(int index)
        {
            return characters[index];
        }

        public List<Character> Characters => new List<Character>(characters);
    }
}
