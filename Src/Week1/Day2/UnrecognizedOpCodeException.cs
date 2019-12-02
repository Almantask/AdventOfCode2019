using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Day2
{
    public class UnrecognizedOpCodeException : Exception
    {
        public UnrecognizedOpCodeException(int literal): base($"Unrecognized literal: {literal}. Something went wrong.")
        {
        }
    }
}
