using FluentAssertions;
using System;
using System.Collections.Generic;
using Week1.Day2;
using Xunit;

namespace Week1.Tests.Day2
{
    public class IntCodeProgramTests
    {
        [Theory]
        [InlineData(@"Day2/Input/EmptyFile.txt", 0)]
        [InlineData(@"Day2/Input/SingleInt.txt", 1)]
        [InlineData(@"Day2/Input/TwoInts.txt", 2)]
        public void IntCodeProgram_With_Valid_PathToSource_Should_Parse_Source_Code_As_Expected(string path, int expectedSourceSize)
        {
            var program = new IntCodeProgram(path);

            program.SourceCode.Should().HaveCount(expectedSourceSize);
        }

        [Theory]
        [InlineData(@"Day2/Input/Notints.txt")]
        public void IntCodeProgram_With_Valid_PathToSource_And_Not_Ints_Should_Throw_InvalidIntCodeProgramException(string path)
        {
            Action initializeIntProgram = () => new IntCodeProgram(path);

            initializeIntProgram.Should().Throw<InvalidIntCodeProgramException>();
        }

        [Fact]
        public void IntCodeProgram_Uncompiled_AlaramCode_ShouldBe_Negative_One()
        {
            var program = new IntCodeProgram(new List<int> { 2 });

            program.AlarmState.Should().Be(-1);
        }

        [Fact]
        public void IntCodeProgram_After_Compile_Given_First_Literal_Is_1_Alarm_Code_Should_Be_1()
        {
            var program = new IntCodeProgram(new List<int> { 1,1,3,0,99 });
            var compiler = new IntCodeCompiler();
            
            compiler.Compile(program);

            program.AlarmState.Should().Be(1);
        }
    }
}
