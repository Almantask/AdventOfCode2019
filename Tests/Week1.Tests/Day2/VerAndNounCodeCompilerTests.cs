using FluentAssertions;
using System;
using System.Collections.Generic;
using Week1.Day2;
using Week1.Tests.Day2.Input;
using Xunit;

namespace Week1.Tests.Day2
{
    public class VerAndNounCodeCompilerTests
    {
        [Theory]
        [ClassData(typeof(InvalidOpCodeVerbAndNounInput))]
        public void No_Possible_Verb_And_Noun_ToS_atisfy_Target_Alarm(List<int> source, int targetAlarm, int lowerBound, int upperBound)
        {
            var program = new IntCodeProgram(source);
            var compiler = new VerbAndNounIntCodeCompiler(targetAlarm, lowerBound, upperBound);

            Action solve = () => compiler.CompileSolution(program);

            solve.Should().ThrowExactly<NoSuitableVerbAndNounFoundException>();
        }

        [Theory]
        [ClassData(typeof(ValidOpCodeVerbAndNounInput))]
        public void Verb_And_Noun_Findable_For_Target_Alarm_Returns_Valid_Solution(List<int> source, int targetAlarm, int lowerBound, int upperBound, int expectedResult)
        {
            var program = new IntCodeProgram(source);
            var compiler = new VerbAndNounIntCodeCompiler(targetAlarm, lowerBound, upperBound);

            var solution = compiler.CompileSolution(program);

            solution.Result.Should().Be(expectedResult);
        }
    }
}
