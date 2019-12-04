using FluentAssertions;
using Week1.Day3;
using Week1.Tests.Day3.Input;
using Xunit;

namespace Week1.Tests.Day3
{
    public class LineTests
    {
        [Theory]
        [ClassData(typeof(PairsOfLinesWithExpectedIntersection))]
        public void Lines_Searching_For_Intersection_Should_Return_Expected_Point(Line line1, Line line2, Point? expectedCrossingPoint)
        {
            var point = line1.Intersect(line2);

            point.Should().BeEquivalentTo(expectedCrossingPoint);
        }
    }
}
