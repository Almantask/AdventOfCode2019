using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Week1.Day3
{
    /// <summary>
    /// Point in 2D space.
    /// </summary>
    public struct Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public static bool operator== (Point p1, Point p2)
        {
            return p1.X == p2.X &&
                   p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2) => !(p1 == p2);
    }
}
