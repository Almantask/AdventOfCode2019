using System;
using System.Collections.Generic;
using System.Linq;
using Week1.Day3;

namespace Week1.Tests.Day3
{
    public struct Line
    {
        private readonly Orientation orientation;

        public readonly Point Start;
        public readonly Point End;

        public Line(Point start, Point end)
        {
            Start = start;
            End = end;

            orientation = (start.Y == end.Y)
                ?Orientation.Horizontal : Orientation.Vertical;
        }

        /// <summary>
        /// Gets all points in between two points.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Point> Plot()
        {
            var points = new List<Point>() {Start};

            if (orientation == Orientation.Horizontal)
            {
                int y = Start.Y;
                var multiplier = (Start.X > End.X) ? -1 : 1;
                var count = Math.Abs(Start.X - End.X);

                for (var x = 1; x < count; x++)
                {
                    var point = new Point(Start.X + x * multiplier, y);
                    points.Add(point);
                }
            }
            else if (orientation == Orientation.Vertical)
            {
                int x = Start.X;
                var multiplier = (Start.Y > End.Y) ? -1 : 1;
                var count = Math.Abs(Start.Y - End.Y);

                for (var y = 1; y < count; y++)
                {
                    var point = new Point(x, Start.Y + y * multiplier);
                    points.Add(point);
                }
            }

            points.Add(End);

            return points;
        }
    }
}
