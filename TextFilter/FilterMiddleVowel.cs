using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextFilter
{
    public class FilterMiddleVowel : FilterBase
    {
        public FilterMiddleVowel() : base("FilterMiddleVowel") { }
        public override OutputText Apply(OutputText text)
        {
            string returnString = text.text;
            var words = Regex.Split(text.text, @"\W")
            .Where(str => !String.IsNullOrEmpty(str)); // Regex //Newline messes up the count!
            foreach (string word in words)
            {
                int wordMiddleIndex = word.Length / 2;
                string vowels = "AaEeIiOoUu";
                Boolean hit = vowels.IndexOf(word[wordMiddleIndex]) >= 0;

                if (word.Length % 2 == 0)
                {
                    int wordMiddle2Index = wordMiddleIndex - 1;
                    hit |= vowels.IndexOf(word[wordMiddle2Index]) >= 0;
                }

                if (hit)
                {
                    // \b - word boundary, so it matches "in" in " in;" but not "in" in "beginning"
                    String regex = "\\b" + word + "\\b";
                    returnString = Regex.Replace(returnString, regex,"");
                }
            }

            return new OutputText(returnString);
        }
    }
}