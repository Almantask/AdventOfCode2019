using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Week1.Day3;

namespace Week1.Tests.Day3.Input
{
    public class WireWithLengthInput : IEnumerable<object[]>

    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[] {"L2", "U2"},
                4
            };

            yield return new object[]
            {
                new[] {"L1"},
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
