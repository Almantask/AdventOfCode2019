using System.Collections;
using System.Collections.Generic;
using Week1.Day3;

public class TangledWiresExpectationsForTangles : IEnumerable<object[]>
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
                new[]
                {
                    new Point(0, 1)
                }
        };

        yield return new object[]
        {
            new[]
            {
                "R1","U1","L1"
            },
            new[]
            {
                "R1","U1","L1"
            },
            new[]
            {
                new Point(1, 0), new Point(1, 1), new Point(0, 1)
            }
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}