using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Week1.Day2
{
    public class IntCodeProgram
    {
        public IList<int> SourceCode { get; }
        public IList<int> CompiledCode { get; set; }

        public int AlarmState => CompiledCode == null? -1: CompiledCode[0];

        public IntCodeProgram(IList<int> sourceCode)
        {
            SourceCode = sourceCode;
        }

        public IntCodeProgram(string path)
        {
            
            var text = File.ReadAllText(path);
            if(string.IsNullOrWhiteSpace(text))
            {
                SourceCode = new List<int>();
                return;
            }

            try
            {
                SourceCode = text.Split(',').Select(l => int.Parse(l)).ToList();
            }
            catch(Exception ex)
            {
                throw new InvalidIntCodeProgramException(path, ex);
            }
        }

        /// <summary>
        /// Adjusts source code with overriden verb and noun values.
        /// </summary>
        /// <param name="verb">Source code value of index 2.</param>
        /// <param name="noun">Source code value of index 1.</param>
        public void ResetTo1202Alaram(int verb, int noun)
        {
            SourceCode[1] = noun;
            SourceCode[2] = verb;
        }
    }
}
