using System;
using System.Collections.Generic;

namespace Week1.Day2
{
    public class IntCodeCompiler
    {
        public void Compile(IntCodeProgram program)
        {
            IList<int> compiled = new List<int>(program.SourceCode);

            var index = 0;
            while (!IsEndOfProgram(index, compiled))
            {
                var literal = compiled[index];
                switch (literal)
                {
                    case OpCode.Add:
                        Add(compiled, index);
                        break;
                    case OpCode.Mutliply:
                        Multiply(compiled, index);
                        break;
                    default:
                        throw new UnrecognizedOpCodeException(literal);
                }

                const int nextOptCodeStep = 4;
                index += nextOptCodeStep;
            }

            program.CompiledCode = compiled;
        }

        private bool IsEndOfProgram(int index, IList<int> program)
        {
            return index >= program.Count || program[index] == (int)OpCode.Finish;
        }

        private void Add(IList<int> program, int index) => OptCodeFunction(program,
            index,
            (a, b) => a + b);

        private void Multiply(IList<int> program, int index) => OptCodeFunction(program, 
            index,
            (a, b) => a * b);

        private void OptCodeFunction(IList<int> program, int index, Func<int, int, int> operation)
        {
            try
            {
                var firstIndex = program[index + 1];
                var secondIndex = program[index + 2];
                var thirdIndex = program[index + 3];

                var first = program[firstIndex];
                var second = program[secondIndex];

                var result = operation(first, second);
                program[thirdIndex] = result;
            }
            catch(Exception ex)
            {
                throw new IndexOutOfRangeException($"OptCode could not be processed at index {index}.{Environment.NewLine}", ex);
            }
            
        }
    }
}