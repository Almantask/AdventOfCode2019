using System;
using System.Collections;
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
            // TODO: Tangles are not matching point, they are points with crossing sections. Fix it.
            var tangles = wire1.Path.Intersect(wire2.Path, 
                new PointEqualityComparer());

            return tangles;
        }
    }
}