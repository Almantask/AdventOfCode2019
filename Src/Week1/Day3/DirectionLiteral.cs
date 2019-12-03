using System;
using System.Collections.Generic;
using System.Text;

namespace Week1.Day3
{
    /// <summary>
    /// Direction literals indicating a direction.
    /// </summary>
    public static class DirectionLiterals
    {
        /// <summary>
        /// Go left.
        /// </summary>
        public const char Left = 'L';

        /// <summary>
        /// Go righ.
        /// </summary>
        public const char Right = 'R';

        /// <summary>
        /// Go up.
        /// </summary>
        public const char Up = 'U';

        /// <summary>
        /// Go down.
        /// </summary>
        public const char Down = 'D';

        /// <summary>
        /// All valid direction literals combined.
        /// </summary>
        public const string Valid = "LRUD";
    }
}
