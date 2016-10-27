using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class NewtonSqrt
    {
        public static decimal Sqrt(long number, int precision = 1)
        {
            int iteration = 0;
            decimal baseNumber = 1;

            while (iteration != 30)
            {
                decimal local = baseNumber;

                baseNumber = (decimal)0.5 * (baseNumber + number / baseNumber);
              

                decimal range = 0;

                if (baseNumber != local)
                    range = local - baseNumber;

                if (range < 1/precision && iteration > 3)//
                {
                    return Math.Round(local,precision);
                }
                iteration++;
                
            }
           
            return Math.Round(baseNumber,precision);
        }
    }
}
