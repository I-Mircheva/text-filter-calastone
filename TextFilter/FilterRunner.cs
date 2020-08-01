using System;
using System.Collections.Generic;

namespace TextFilter
{
    public class FilterRunner
    {
        public List<FilterBase> filters { get; set; }
        public FilterRunner(List<FilterBase> filters)
        {
            this.filters = filters;
        }

        public OutputText Run(string text)
        {
            var outputText = new OutputText(text);
            foreach (FilterBase filter in filters)
            {
                Console.WriteLine(outputText.text);
                outputText = filter.Apply(outputText);
            }
            return outputText;
        }
    }
}