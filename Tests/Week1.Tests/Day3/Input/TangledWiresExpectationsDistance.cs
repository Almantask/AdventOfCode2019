using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Week1.Tests.Day3.Input
{
    public class TangledWiresExpectationsDistance : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new[]
                {
                    "R1","U1","L1"
                },
                new[]
                {
                    "U1"
                },
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
