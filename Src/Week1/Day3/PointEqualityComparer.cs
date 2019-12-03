using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Day3
{
    public class PointEqualityComparer: IEqualityComparer<Point>
    {
        public bool Equals(Point p1, Point p2) => p1 == p2;

        public int GetHashCode(Point point)
        {
            // https://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-overriding-gethashcode
            unchecked // Overflow is fine, just wrap
            {
                int hash = 17;
                // Suitable nullity checks etc, of course :)
                hash = hash * 23 + point.X.GetHashCode();
                hash = hash * 23 + point.Y.GetHashCode();
                return hash;
            }
        }
    }
}
