using System.Collections;
using System.Collections.Generic;

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
            yield return new object[]
            {
                new[]
                {
                    "R1","U1","L2"
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
