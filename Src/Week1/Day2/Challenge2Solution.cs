namespace Week1.Day2
{
    public struct Challenge2Solution
    {
        public int Result => 100 * Noun + Verb;

        /// <summary>
        /// Program value at index 2.
        /// </summary>
        public readonly int Verb;
        /// <summary>
        /// Program value at index 1.
        /// </summary>
        public readonly int Noun;

        public Challenge2Solution(int verb, int noun)
        {
            Verb = verb;
            Noun = noun;
        }

        public override string ToString() => $"100 x {Noun} + {Verb}= {Result}";
    }
}
