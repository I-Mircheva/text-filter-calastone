using System;

namespace TextFilter
{
    public abstract class FilterBase
    {
        public string name;
        public FilterBase(string name)
        {
            this.name = name;
        }
        public abstract OutputText Apply(OutputText text);
    }
}