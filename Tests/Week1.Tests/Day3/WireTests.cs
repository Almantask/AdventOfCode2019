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
        public void Valid_Wire_Returns_Expected_Length_Of_Wire(string[] path, int expectedLength)
        {
            var wire = new Wire(path);

            var length = wire.CalculateLength();

            length.Should().Be(expectedLength);
        }

        [Theory]
        [ClassData(typeof(WireWithPointOfWireInput))]
        public void Valid_Wire_Lenght_To_Point_Return_Expected_Length(string[] path, Point point, int expectedLength)
        {
            var wire = new Wire(path);

            var length = wire.CalculateLengthToPoint(point);

            length.Should().Be(expectedLength);
        }

    }
}
