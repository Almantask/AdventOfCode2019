using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Day3.Exceptions
{
    public class PointNotBelongingToWireException: Exception
    {
        public PointNotBelongingToWireException(Point point): base($"Point: [{point.X},{point.Y}] does not belong to the wire.") 
        {

        }
    }
}
