using System.Collections.Generic;
using FluentAssertions;
using Week1.Day3;
using Xunit;

namespace Week1.Tests.Day3
{
    public class PointTests
    {
        [Theory]
        [MemberData(nameof(EqualsPoints))]
        public void Comparing_Equal_Points_Should_Return_True(Point p1, Point p2)
        {
            var areEqual = p1 == p2;

            areEqual.Should().Be(true);
        }

        [Theory]
        [MemberData(nameof(UnequalPoints))]
        public void Comparing_Unequal_Points_Should_Return_False(Point p1, Point p2)
        {
            var areEqual = p1 == p2;

            areEqual.Should().Be(false);
        }

        public static IEnumerable<object[]> EqualsPoints =>
            new List<object[]>()
            {
                new object[]{new Point(0,0), new Point(0,0)},
                new object[]{new Point(0,1), new Point(0,1)},
                new object[]{new Point(1,0), new Point(1,0)},
                new object[]{new Point(int.MaxValue, int.MaxValue), new Point(int.MaxValue, int.MaxValue)}
            };

        public static IEnumerable<object[]> UnequalPoints =>
            new List<object[]>()
            {
                new object[]{new Point(0,1), new Point(0,0)},
                new object[]{new Point(0,0), new Point(0,1)},
                new object[]{new Point(1,0), new Point(0,0)},
                new object[]{new Point(int.MaxValue, 0), new Point(int.MaxValue, int.MaxValue)}
            };
    }

}
