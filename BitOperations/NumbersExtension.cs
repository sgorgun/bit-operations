using System;

namespace BitOperationsTask
{
    /// <summary>
    /// Provides static method for working with integers.
    /// </summary>
    public static class NumbersExtension
    {
        /// <summary>
        /// Inserts first (j - i + 1), (i less or equals j) bits sequence from second number into first number from i to j position.
        /// </summary>
        /// <param name="destinationNumber">Destination number.</param>
        /// <param name="sourceNumber">Source number.</param>
        /// <param name="i">i position in source number.</param>
        /// <param name="j">j position in source number.</param>
        /// <returns>Changed first number (see summary).</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when i or j is less than 0 or more than 31.</exception>
        /// <exception cref="ArgumentException">Thrown when i is more than j.</exception>
        /// <example>
        /// Destination number = 2728, Source number = 655, i = 3, j = 8, Result = 2680,
        /// Destination number = 554216104, Source number = 15, i = 0, j = 31, Result = 15,
        /// Destination number = -55465467, Source number = 345346, i = 0, j = 31, Result = 345346,
        /// Destination number = 554216104, Source number = 4460559, i = 11, j = 18, Result = 554203816,
        /// Destination number = -1, Source number = 0, i = 31, j = 31, Result = 2147483647.
        /// </example>
        public static int InsertNumberIntoAnother(int destinationNumber, int sourceNumber, int i, int j)
        {
            throw new NotImplementedException("You need to implement this function.");
        }
    }
}
