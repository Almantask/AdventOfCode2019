using System;
using System.Collections;
using System.Collections.Generic;

namespace Week1.Tests.Day2.Input
{
    internal class InvalidOpCodeVerbAndNounInput : IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[]
            {
                new List<int>
                {
                    1,0,0,0,99
                },
                5,
                0, 
                1
            };
        }

        IEnumerator IEnumerable.GetEnumerator() => throw new NotImplementedException();
    }
}
