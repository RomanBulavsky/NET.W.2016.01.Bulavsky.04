using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class NewtonSqrt
    {
        /// <summary>
        /// Method that uses Newton method for finding <paramref name="power"/> degree from <paramref name="number"/>
        /// </summary>
        /// <param name="epsilon">Specifies the precision of calculations</param>
        /// <returns>The number of the extracted root with a given accuracy(<paramref name="epsilon"/>).</returns>
        public static double NSqrt(double number, int power, double epsilon)
        {
            if (number.Equals(0)) return 0;
            if (power < 1)
                throw new ArgumentException();
            if (!(epsilon > 0 && epsilon < 1))
                throw new ArgumentException();
            if (((power%2) == 0) && number < 0)
                throw new ArgumentException();

            number = Math.Abs(number);
            var currentX = 0.0;
            var nextX = 1.0;
            while (Math.Abs(nextX - currentX) > epsilon)
            {
                currentX = nextX;
                nextX = 1.0/power*((power - 1)*currentX + number/Math.Pow(currentX, power - 1));
            }
            return nextX;
        }
    }
}