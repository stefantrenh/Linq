using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqApplication.LinqApplication.Library.Contains
{
    public class ContainsRefactoryChallange
    {
        //TODO implement this method
        public static bool ContainsBannedWords_Refactored(IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            return words.Any(x => bannedWords.Contains(x));
        }

        //do not modify this method
        public static bool ContainsBannedWords(IEnumerable<string> words, IEnumerable<string> bannedWords)
        {
            foreach (var word in words)
            {
                foreach (var bannedWord in bannedWords)
                {
                    if (word == bannedWord)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
