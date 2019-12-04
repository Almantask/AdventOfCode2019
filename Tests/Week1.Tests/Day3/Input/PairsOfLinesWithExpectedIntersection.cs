using System.Collections;
using System.Collections.Generic;
using Week1.Day3;

namespace Week1.Tests.Day3.Input
{
    public class PairsOfLinesWithExpectedIntersection: IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            // -  +
            //210123
            //..|..1
            //.-X-.0
            //..|..-1
            yield return new object[]
            {
                new Line(new Point(0, -1), new Point(0, 1)),
                new Line(new Point(-1, 0), new Point(1, 0)),
                new Point(0,0), 
            };
            // -  +
            //21012
            //....1
            //.X-.0
            //.|..-1
            yield return new object[]
            {
                new Line(new Point(-1, -1), new Point(-1, 0)),
                new Line(new Point(0, 0), new Point(-1, 0)),
                new Point(-1, 0),
            };
            yield return new object[]
            {
                new Line(new Point(0, 0), new Point(-1, 0)),
                new Line(new Point(-1, -1), new Point(-1, 0)),
                new Point(-1, 0),
            };
            // -  +
            //21012
            //....1
            //.--.0
            //.--.-1
            yield return new object[]
            {
                new Line(new Point(-1, -1), new Point(0, -1)),
                new Line(new Point(-1, 0), new Point(0, 0)),
                null,
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}