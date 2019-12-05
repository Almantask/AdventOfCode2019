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

        public Point? Intersect(Line line2)
        {

            if (this.orientation == line2.orientation) return null;


            var intersection = Intersect(this, line2);
            if (intersection != null) return intersection;

            return Intersect(line2, this);
        }

        public Point? Intersect(Line line1, Line line2)
        {
            int x = 0;
            int y = 0; 

            if (line1.orientation == Orientation.Horizontal)
            {
                //   101
                //....|......1
                //....--.....0
                //............1
                y = line1.Start.Y;

                var isYInBetween = (y >= line2.Start.Y && y <= line2.End.Y) ||
                                   (y >= line2.End.Y && y <= line2.Start.Y);

                if (!isYInBetween) return null;

                x = line2.Start.X;
                // Presume the other orientation is vertical
                var isXOfOtherInBetween = (x >= line1.Start.X && x <= line1.End.X) ||
                                          (x >= line1.End.X && x <= line1.Start.X);

                if (!isXOfOtherInBetween) return null;
            }
            else
            {
                //...|....
                //.--x--..
                //........
                //.-----..

                //.........
                //...|....1
                //..-x-...0
                //...|....-1
                //.-----..
                x = line1.Start.X;

                var isYInBetween = (x >= line2.Start.X && x <= line2.End.X) ||
                                   (x >= line2.End.Y && x <= line2.Start.X);

                if (!isYInBetween) return null;

                y = line2.Start.Y;
                // Presume the other orientation is vertical
                var isXOfOtherInBetween = (y >= line1.Start.Y && y <= line1.End.Y) ||
                                          (y >= line1.End.Y && y <= line1.Start.Y);

                if (!isXOfOtherInBetween) return null;
            }

            return new Point(x, y);
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
                // plot X x-------x
                // y is constant;
                int y = Start.Y;

                int startX;
                int endX;
                if (Start.X > End.X)
                {
                    startX = End.X;
                    endX = Start.X;
                }
                else
                {
                    startX = Start.X;
                    endX = End.X;
                }

                for (var x = startX + 1; x < endX; x++)
                {
                    var point = new Point(x, y);
                    points.Add(point);
                }
            }
            else if (orientation == Orientation.Vertical)
            {
                // plot Y 
                //x
                //|
                //|
                //x
                
                // X is constant
                int x = Start.X;

                int startY;
                int endY;
                if(Start.Y > End.Y)
                {
                    startY = End.Y;
                    endY = Start.Y;
                }
                else
                {
                    startY = Start.Y;
                    endY = End.Y;
                }

                for (var y = startY + 1; y < endY; y++)
                {
                    var point = new Point(x, y);
                    points.Add(point);
                }
            }

            points.Add(End);

            return points;
        }
    }
}
