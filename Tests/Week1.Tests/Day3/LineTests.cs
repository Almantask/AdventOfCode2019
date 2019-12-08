using System.Collections.Generic;
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

        [Theory]
        [MemberData(nameof(PointsPlotInput))]
        public void Plot_In_Between_Two_Points_Should_Include_Both_Points_And_More(Point point1, Point point2, IEnumerable<Point> expectedPlot)
        {
            var line = new Line(point1, point2);

            var plot = line.Plot();

            plot.Should().BeEquivalentTo(expectedPlot);
        }

        public static IEnumerable<object[]> PointsPlotInput =>
            new List<object[]>()
            {
                new object[]
                {
                    new Point(0, 0), new Point(0, 2),
                    new[] {new Point(0, 0), new Point(0, 1), new Point(0, 2)}
                },
                new object[]
                {
                    new Point(0, 0), new Point(2, 0),
                    new[] {new Point(0, 0), new Point(1, 0), new Point(2, 0)}
                },
                new object[]
                {
                    new Point(0, 0), new Point(-2, 0),
                    new[] {new Point(0, 0), new Point(-1, 0), new Point(-2, 0)}
                },
                new object[]
                {
                    new Point(0, 0), new Point(0, -2),
                    new[] {new Point(0, 0), new Point(0, -1), new Point(0, -2)}
                }
            };

    }
}
