namespace Week1.Day2
{
    /// <summary>
    /// Intcode literals.
    /// </summary>
    public static class OpCode
    {
        /// <summary>
        /// End of program.
        /// </summary>
        public const int Finish = 99;
        /// <summary>
        /// Adds together numbers read from next two positions (their indices) and stores (or overrides) the result in a third index position.
        /// Steps ahead 4 positions. Positions start from 0th index in list.
        /// </summary>
        public const int Add = 1;
        /// <summary>
        /// Multiplies together numbers read from next two positions (their indices) and stores (or overrides) the result in a third index position.
        /// Steps ahead 4 positions. Positions start from 0th index in list.
        /// </summary>
        public const int Mutliply = 2;
    }
}
