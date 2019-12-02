using System.Collections;
using System.Collections.Generic;

namespace Week1.Tests.Day2
{
    internal class ValidOpCodeInput : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<int>
                {
                    1,0,0,0,99
                },
                new List<int>
                {
                    2,0,0,0,99
                }
            };
            yield return new object[]
            {
                new List<int>
                {
                    1,9,10,3,
                    2,3,11,0,
                    99,
                    30,40,50
                },
                new List<int>
                {
                    3500,9,10,70,
                    2,3,11,0,
                    99,
                    30,40,50
                }
            };
            yield return new object[]
            {
                new List<int>
                {
                    2,3,0,3,99
                },
                new List<int>
                {
                    2,3,0,6,99
                }
            };
            yield return new object[]
            {
                new List<int>
                {
                    2,4,4,5,99,0
                },
                new List<int>
                {
                    2,4,4,5,99,9801
                }
            };
            yield return new object[]
            {
                new List<int>
                {
                    1,1,1,4,99,5,6,0,99
                },
                new List<int>
                {
                    30,1,1,4,2,5,6,0,99
                }
            };
            yield return new object[]
            {
                new List<int>(),
                new List<int>()
            };
            yield return new object[]
            {
                new List<int>()
                {
                    99
                },
                new List<int>()
                {
                    99
                },
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}