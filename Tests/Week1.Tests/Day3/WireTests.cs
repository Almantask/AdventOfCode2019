using FluentAssertions;
using Week1.Day3;
using Week1.Tests.Day3.Input;
using Xunit;

namespace Week1.Tests.Day3
{
    public class WireTests
    {
        [Theory]
        [ClassData(typeof(SingleWireLiteralsExpectation))]
        public void Valid_Literals_In_String_Array_For_Wire_Initialization_Returns_Expected_Point(string[] path, Point[] points)
        {
            var wire = new Wire(path);

            wire.Path.Should().BeEquivalentTo(points);
        }

        [Theory]
        [ClassData(typeof(WireWithLengthInput))]
        public void Valid_Wire_Returns_Expected_Distance(string[] path, int expectedLength)
        {
            var wire = new Wire(path);

            var length = wire.GetLength();

            length.Should().Be(expectedLength);
        }

    }
}
