using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class NewtonSqrt
    {
        public static string Sqrt(long number, int precision = 1)
        {
            number = Math.Abs(number);

            var iteration = 0;
            var baseNumber = 1M;

            while (iteration != 30)
            {
                decimal local = baseNumber;

                baseNumber = (decimal)0.5 * (baseNumber + number / baseNumber);
              

                decimal range = 0;

                if (baseNumber != local)
                    range = local - baseNumber;

                if (range < (decimal)Math.Pow(10, -1 * precision) && iteration > 3)// We need min 3 iterations for normal result.
                {
                    return Math.Round(local,precision).ToString();// For more accurate testing.
                }

                iteration++;
                
            }
           
            return Math.Round(baseNumber,precision).ToString();// Here too.
        }
    }
}
