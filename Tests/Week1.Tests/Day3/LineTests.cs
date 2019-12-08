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
                },
            };

    }
}
