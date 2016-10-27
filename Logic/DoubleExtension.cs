using System;
using System.Collections;
using System.Linq;

namespace Logic
{
    public static class DoubleExtension
    {
        public static string ShowIn754(this double number)
        {
            double f = number;
            byte[] b = BitConverter.GetBytes(f);
           
            BitArray a = new BitArray(b);
            
            char[] baseArray = new char[64];

            baseArray = Enumerable.Repeat('0', 64).ToArray();// 0{32}
            for (int i = 0; i < 64; i++)
            {
                if (a[i])
                {
                    baseArray[63 - i] = '1';
                }
            }

            
            return new string(baseArray);
        }
    }
}
