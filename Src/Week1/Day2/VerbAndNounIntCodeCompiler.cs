using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Day2
{
    public class VerbAndNounIntCodeCompiler: IntCodeCompiler
    {
        private readonly int _alarmTarget;
        private readonly int _lowerBound;
        private readonly int _upperBound;

        public VerbAndNounIntCodeCompiler(int alarmTarget, int lowerBound, int upperBound)
        {
            _alarmTarget = alarmTarget;
            _lowerBound = lowerBound;
            _upperBound = upperBound;
        }

        public Challenge2Solution CompileSolution(IntCodeProgram program)
        {
            for(var noun = _lowerBound; noun <= _upperBound; noun++)
            {
                for(var verb = _lowerBound; verb <= _upperBound; verb++)
                {
                    program.ResetTo1202Alaram(verb, noun);
                    Compile(program);

                    if (program.AlarmState == _alarmTarget)
                    {
                        return new Challenge2Solution(verb, noun);
                    }
                }
            }

            throw new NoSuitableVerbAndNounFoundException(program.SourceCode, _lowerBound, _upperBound);
        }
    }
}
