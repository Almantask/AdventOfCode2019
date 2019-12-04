using System.Collections.Generic;
using FluentAssertions;
using Week1.Day3;
using Week1.Tests.Day3.Input;
using Xunit;

namespace Week1.Tests.Day3
{
    public class CrossedWiresTest
    {
        [Theory]
        [ClassData(typeof(TangledWiresExpectationsDistance))]
        public void Valid_Path_Literals_Returns_Closest_Intersection_Point(string[] path1, string[] path2, long expectedDistance)
        {
            var wireUntangler = new WireUntangler();

            var wire1 = new Wire(path1);
            var wire2 = new Wire(path2);

            var closestTangle = wireUntangler.CalculateShortestDistanceToOrigin(wire1, wire2);

            closestTangle.Should().Be(expectedDistance);
        }

        [Theory]
        [ClassData(typeof(TangledWiresExpectationsForTangles))]
        public void Valid_Path_Literals_Returns_All_Intersection_Points(string[] path1, string[] path2, IEnumerable<Point> expectedTangles)
        {
            var wireUntangler = new WireUntangler();
            var wire1 = new Wire(path1);
            var wire2 = new Wire(path2);

            var tangles = wireUntangler.FindTangles(wire1, wire2);

            tangles.Should().BeEquivalentTo(expectedTangles);
        }
    }
}
