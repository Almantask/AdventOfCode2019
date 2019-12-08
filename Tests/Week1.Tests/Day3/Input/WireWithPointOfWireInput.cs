using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Week1.Day3;

namespace Week1.Tests.Day3.Input
{
    public class WireWithPointOfWireInput : IEnumerable<object[]>

    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {"L2", "U2"},
                new Point(-2, 0),
                2
            };

            yield return new object[]
            {
                new[] {"L2", "L2", "U2"},
                new Point(-4, 1),
                5
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
