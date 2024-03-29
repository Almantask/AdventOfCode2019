﻿using System.Collections;
using System.Collections.Generic;
using Week1.Day3;

public class SingleWireLiteralsExpectation : IEnumerable<object[]>
{
    public IEnumerator<object[]> GetEnumerator()
    {
        yield return new object[]
        {
                new[]
                {
                    "R1"
                },
                new[]
                {
                    new Point(1, 0)
                }
        };
        yield return new object[]
        {
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
                "D1"
            },
            new[]
            {
                new Point(0, -1)
            }
        };
        yield return new object[]
        {
            new[]
            {
                "L1"
            },
            new[]
            {
                new Point(-1, 0)
            }
        };
        yield return new object[]
        {
            new[]
            {
                "R1", "U1", "L1", "D1"
            },
            new[]
            {
                new Point(1, 0), new Point(1, 1), new Point(0, 1), new Point(0,0) 
            }
        };
        yield return new object[]
        {
            new[]
            {
                "R2", "U2", "L2", "D2"
            },
            new[]
            {
                new Point(1, 0), new Point(2, 0), 
                new Point(2, 1), new Point(2, 2), 
                new Point(1, 2), new Point(0, 2),
                new Point(0, 1), new Point(0, 0)  
            }
        };
        yield return new object[]
        {
            new[]
            {
                "R2", "U1", "L1", "D2"
            },
            new[]
            {
                new Point(1, 0), new Point(2, 0),
                new Point(2, 1),
                new Point(1, 1),
                new Point(1, 0), new Point(1, -1)
            }
        };
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}