using System.Collections.Generic;
using System.Linq;
using Week1.Day3;

namespace Week1.Tests.Day3
{
    public class WireUntangler
    {
        /// <summary>
        /// Finds point with coordinate sum smallest.
        /// Origin is a point where both wires started.
        /// </summary>
        public long CalculateShortestDistanceToOrigin(Wire wire1, Wire wire2)
        {
            var closest = FindClosestTangle(wire1, wire2);

            return closest.X + closest.Y;
        }

        /// <summary>
        /// Finds point with coordinate sum smallest.
        /// Origin is a point where both wires started.
        /// </summary>
        public Point FindClosestTangle(Wire wire1, Wire wire2)
        {
            var tangles = FindTangles(wire1, wire2);

            return tangles.Min();
        }

        /// <summary>
        /// Finds all the tangles between wire1 and wire2.
        /// </summary>
        /// <param name="wire1">Wires expressed in <see cref="DirectionLiterals"/> followed by an integer for how many units to move in that direction.</param>
        /// <param name="wire2">>Wires expressed in <see cref="DirectionLiterals"/> followed by an integer for how many units to move in that direction.</param>
        /// <returns></returns>
        public IEnumerable<Point> FindTangles(Wire wire1, Wire wire2)
        {
            var tangles = new List<Point>();

            var lines1 = BuildLines(wire1);
            var lines2 = BuildLines(wire2);

            foreach (var line1 in lines1)
            {
                foreach (var line2 in lines2)
                {
                    var intersection = line1.Intersect(line2);
                    if (intersection == null) continue;
                    if (intersection == Panel.OriginPoint) continue;

                    tangles.Add(intersection.Value);
                }
            }

            return tangles.Distinct(new PointEqualityComparer());
        }

        private IList<Line> BuildLines(Wire wire)
        {
            var lines = new List<Line>();

            lines.Add(new Line(Panel.OriginPoint, wire.Path[0]));

            for (var index = 0; index < wire.Path.Count - 1; index++)
            {
                lines.Add(new Line(wire.Path[index], wire.Path[index + 1]));
            }

            return lines;
        }
    }
}