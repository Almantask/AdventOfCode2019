using System;
using System.Collections.Generic;
using System.Linq;

namespace Week1.Day2
{
    public class NoSuitableVerbAndNounFoundException: Exception
    {
        public NoSuitableVerbAndNounFoundException(IList<int> source, int lowerBound, int upperBound): base("No matching verb and noun found for the source code" +
            $"{Environment.NewLine}" +
            $"{string.Join(",",source.Select(l => l.ToString()))}" +
           $"{Environment.NewLine}" +
            $"Lower bound: {lowerBound}, upper bound {upperBound}.")
        {
        }
    }
}
