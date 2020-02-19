using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Peoblems
{
    public class KeybaordRow
    {
        char[] row1 = {'q','w','e','r','t','y','u','i','o','p' };
        char[] row2 = { 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l' };
        char[] row3 = { 'z', 'x', 'c', 'v', 'b', 'n', 'm' };

        public string[] FindWords(string[] words)
        {
            List<String> validWords = new List<string>();

            foreach(string word in words)
            {
                if(FindInRow(word, row1))
                {
                    validWords.Add(word);
                }
                if (FindInRow(word, row2))
                {
                    validWords.Add(word);
                }
                if (FindInRow(word, row3))
                {
                    validWords.Add(word);
                }
            }


            return validWords.ToArray();
        }

        private bool FindInRow(string word, char[] row)
        {
            char[] letters = word.ToLower().ToCharArray();

            foreach(char letter in letters)
            {
                if(!row.Contains(letter))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
