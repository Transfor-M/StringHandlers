using System.Collections.Generic;

namespace StringHandlers
{
    public static class StringProcessor
    {
        public static string FindDistinctCharacters(string source)
        {
            return new HashSet<char>(source).ToString();
        }
    }
}