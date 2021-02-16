using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsPalindrome(string word)
        {
            var reverseWord = word.Reverse();
            return word.ToLower().SequenceEqual(reverseWord);
        }
    }
}
