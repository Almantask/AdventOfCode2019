using System;

namespace Week1.Day2
{
    public class InvalidIntCodeProgramException: Exception
    {
        public InvalidIntCodeProgramException(string file, Exception ex): base($"Failed to parse IntCode from a text file {file}.{Environment.NewLine}" +
            $"A program should be comma separated integers with no spaces in between.", ex)
        {
        }
    }
}
