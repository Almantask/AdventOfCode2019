using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Week1.Day3.Exceptions;
using static Week1.Day3.DirectionLiterals;

namespace Week1.Day3
{
    public struct Wire
    {
        public readonly IReadOnlyList<Point> Path;

        public Wire(string[] path)
        {
            Path = Parse(path);
        }

        private static IReadOnlyList<Point> Parse(string[] literals)
        {
            var path = new List<Point>();

            // Origin point- weherever we start is 0,0.
            int x = 0;
            int y = 0;

            foreach (var literal in literals)
            {
                var directionPoint = Parse(literal);

                // Let's keep track where we are relatively.
                x += directionPoint.X;
                y += directionPoint.Y;

                // Get relative point to origin
                var actualPoint = new Point(x, y);
                path.Add(actualPoint);
            }

            return path;
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
