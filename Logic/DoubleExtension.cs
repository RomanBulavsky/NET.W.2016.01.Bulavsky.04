using System;
using System.Collections;
using System.Linq;

namespace Logic
{
    public static class DoubleExtension
    {
        /// <summary>
        /// Extension method that shows the binary representation of real numbers.
        /// </summary>
        /// <param name="number"> Real number that we want to format.</param>
        /// <returns> Representation of real numbers in IEEE754 format.</returns>
        public static string ShowInIEEE754Format(this double number)
        {
            var bitArray = new BitArray(BitConverter.GetBytes(number));
            var baseArray = Enumerable.Repeat('0', sizeof(double)*8).ToArray();
            for (var i = 0; i < sizeof(double)*8; i++)
                if (bitArray[i])
                    baseArray[sizeof(double)*8 - 1 - i] = '1'; //63 looks better... or 64 - 1

            return new string(baseArray);
        }
    }
}