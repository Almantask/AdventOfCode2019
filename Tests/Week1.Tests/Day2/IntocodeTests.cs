using System.Collections.Generic;
using Xunit;
using FluentAssertions;
using Week1.Day2;
using System;

namespace Week1.Tests.Day2
{
    public class IntocodeTests
    {
        [Theory]
        [ClassData(typeof(ValidOpCodeInput))]
        public void Valid_IntCode_Returns_Expected_Compiled_Program(IList<int> sourceCode, IList<int> expectedCode)
        {
            var program = new IntCodeProgram(sourceCode);
            var intCodeProcessor = new IntCodeCompiler();

            intCodeProcessor.Compile(program);

            program.CompiledCode.Should().BeEquivalentTo(expectedCode);
        }

        [Theory]
        [MemberData(nameof(UnrecognizedLiteralInput))]
        public void Unrecognized_OpCode_Throws_UnrecognizedOpCodeException(IList<int> sourceCode)
        {
            var program = new IntCodeProgram(sourceCode);
            var intCodeProcessor = new IntCodeCompiler();

            Action compile = () => intCodeProcessor.Compile(program);

            compile.Should().ThrowExactly<UnrecognizedOpCodeException>();
        }

        [Theory]
        [MemberData(nameof(OutOfRangeInput))]
        public void OpCode_Operation_Not_Enough_Literals_Throws_IndexOutOfRangeException(IList<int> sourceCode)
        {
            var program = new IntCodeProgram(sourceCode);
            var intCodeProcessor = new IntCodeCompiler();

            Action compile = () => intCodeProcessor.Compile(program);

            compile.Should().ThrowExactly<IndexOutOfRangeException>();
        }

        public static IEnumerable<object[]> UnrecognizedLiteralInput =>
        new List<object[]>
        {
            new object[]
            {
                new List<int>
                {
                    0,0,0
                }
            }
        };

        public static IEnumerable<object[]> OutOfRangeInput =>
        new List<object[]>
        {
            new object[]
            {
                new List<int>
                {
                    1,0
                }
            }
        };

    }
}
