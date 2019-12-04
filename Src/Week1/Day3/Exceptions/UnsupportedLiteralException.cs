using System;

namespace Week1.Day3.Exceptions
{
    public class UnsupportedLiteralException: Exception
    {
        /// <summary>
        /// For first literal.
        /// </summary>
        /// <param name="literal"></param>
        public UnsupportedLiteralException(char literal): base($"Literal '{literal}' is not a part of supported literals - '{DirectionLiterals.Valid}'.")
        {
        }

        /// <summary>
        /// For all except first literal.
        /// </summary>
        /// <param name="literal"></param>
        public UnsupportedLiteralException(string literal) : base($"Literal '{literal}' is not an integer.")
        {
        }
    }
}
