
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TextFilter
{
    public class FilterLetterT : FilterBase
    {
        public FilterLetterT() : base("FilterLetterT") { }
        public override OutputText Apply(OutputText text)
        {
            string returnString = text.text;
            var words = Regex.Split(text.text, @"\W")
            .Where(str => !String.IsNullOrEmpty(str)); //Empty string messes up the count!
            foreach (string word in words)
            {
                if (word.Contains("t"))
                {
                    // \b - word boundary, so it matches "in" in " in;" but not "in" in "beginning"
                    String regex = "\\b" + word + "\\b";
                    returnString = Regex.Replace(returnString, regex, "");
                }
            }

            return new OutputText(returnString);
        }
    }
}