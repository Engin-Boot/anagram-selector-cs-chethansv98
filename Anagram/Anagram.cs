using System;
using System.Collections.Generic;

namespace Anagram
{
    public class AnagramSelector
    {
        public bool WordPairIsAnagram(string word1, string word2) {
            char[] char1 = word1.ToLower().ToCharArray();  
            char[] char2 = word2.ToLower().ToCharArray();  
            Array.Sort(char1);  
            Array.Sort(char2); 
            string NewWord1 = new string(char1);  
            string NewWord2 = new string(char2); 
            if (NewWord1 == NewWord2) {
                return true;
            }
            return false;
        }
        public List<string> SelectAnagrams(string word, List<string> candidates) {
            for(int i = 0; i < candidates.Count; i++)
            {
                if(!WordPairIsAnagram(word, candidates[i]))
                {
                    candidates.RemoveAt(i);
                }
            }
            return candidates;
        }
    }
}
