using System;
using System.Collections.Generic;
using System.Linq;
using Week1.Day3.Exceptions;
using Week1.Tests.Day3;
using static Week1.Day3.DirectionLiterals;

namespace Week1.Day3
{
    public struct Wire
    {
        public readonly IList<Point> Path;

        public Wire(string[] path)
        {
            Path = Parse(path);
        }

        public int CalculateLength() => CalculateLengthToPoint(Path.Last());

        public int CalculateLengthToPoint(Point tanglePoint)
        {
            var distance = 0;

            foreach (var point in Path)
            {
                distance++;
                if (point == tanglePoint) return distance;
            }

            throw new PointNotBelongingToWireException(tanglePoint);
        }

        /// <summary>
        /// Returns plotted point in between wire corners.
        /// </summary>
        /// <param name="literals"></param>
        /// <returns></returns>
        private static IList<Point> Parse(string[] literals)
        {
            var plottedPoints = new List<Point>();

            var pathCorners = GetCorners(literals);
            if (pathCorners.Count == 1) return pathCorners;

            // Plot from origin (or include origin in the wire setup paths.
            var lineFromOrigin = new Line(Panel.OriginPoint, pathCorners[0]);
            plottedPoints.AddRange(lineFromOrigin.Plot());

            for (var i = 0; i < pathCorners.Count -1; i++)
            {
                plottedPoints.Remove(plottedPoints.Last());

                var line = new Line(pathCorners[i], pathCorners[i+1]);
                plottedPoints.AddRange(line.Plot());
            }

            plottedPoints.Remove(Panel.OriginPoint);

            return plottedPoints;
        }

        private static List<Point> GetCorners(string[] literals)
        {
            var pathCorners = new List<Point>();

            // Origin point- weherever we start is 0,0.
            int x = 0;
            int y = 0;

            for (var index = 0; index < literals.Length; index++)
            {
                var literal = literals[index];
                var directionPoint = Parse(literal);

                // Let's keep track where we are relatively.
                x += directionPoint.X;
                y += directionPoint.Y;

                // Get relative point to origin
                var actualPoint = new Point(x, y);
                pathCorners.Add(actualPoint);
            }

            return pathCorners;
        }

        private static Point Parse(string literal)
        {
            var direction = literal[0];
            if (!Valid.Contains(direction))
            {
                throw new UnsupportedLiteralException(direction);
            }

            int units;
            var unitLiterals = literal.Substring(1);
            var isNumber = int.TryParse(unitLiterals, out units);
            if (!isNumber)
            {
                throw new UnsupportedLiteralException(unitLiterals);
            }

            int x = 0;
            int y = 0;
            switch (direction)
            {
                case Up:
                    x = 0;
                    y = 1 * units;
                    break;
                case Down:
                    x = 0;
                    y = -1 * units;
                    break;
                case Left:
                    x = -1 * units;
                    y = 0;
                    break;
                case Right:
                    x = 1 * units;
                    y = 0;
                    break;
            }

            return new Point(x, y);
        }
    }
}
