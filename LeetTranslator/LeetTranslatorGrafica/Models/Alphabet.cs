using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetTranslatorGrafica.Models
{
    public class Alphabet
    {
        private string name;
        private List<Character> characters;

        private Alphabet(string name)
        {
            this.name = name;
        }

        public Alphabet(string name, List<Character> characters)
            : this(name)
        {
            this.characters = characters;
        }

        public Alphabet(string name, Character[] characters)
            : this(name)
        {
            this.characters = characters.ToList();
        }

        public Character GetCharacter(int index)
        {
            return characters[index];
        }

        public string Name => name;
        public List<Character> Characters => new List<Character>(characters);
    }
}
