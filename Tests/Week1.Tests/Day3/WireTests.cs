using FluentAssertions;
using Week1.Day3;
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
    }
}
