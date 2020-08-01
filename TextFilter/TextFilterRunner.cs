using System;
using System.Collections.Generic;

namespace TextFilter
{
    public class TextFilterRunner
    {
        public static void Main(string[] args)
        {
            var fileReader = new FileReader();
            var readText = fileReader.Read("./input.txt");

            var filterList = new List<FilterBase>();
            filterList.Add(new FilterMiddleVowel());
            filterList.Add(new FilterLengthThree());
            filterList.Add(new FilterLetterT());

            var filterRunner = new FilterRunner(filterList);
            var filteredText = filterRunner.Run(readText);

            Console.WriteLine(filteredText.text);
        }
    }
}
