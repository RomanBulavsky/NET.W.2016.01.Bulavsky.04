using System;
using static Logic.NewtonSqrt;
using NUnit.Framework;

namespace Logic.NUnit.Tests
{
    [TestFixture]
    public class NewtonSqrtTests
    {
        [TestCase(9, 2, 0.001, 3)]
        [TestCase(8, 2, 0.01, 2.82)]
        [TestCase(13, 2, 0.1, 3.6)]
        [TestCase(8, 2, 0.00000001, 2.828427124)]
        [TestCase(135587, 2, 0.000000000000000000001, 368.22140079033972411077021)]
        public void NSqrt_NumberPowerAndEpsilon_ExpectedNumber(double number, int power, double epsilon, double expected)
        {
            var result = NSqrt(number, power, epsilon);
            Assert.GreaterOrEqual(result, expected);
        }

        [TestCase(11, 3, -1.11)]
        [TestCase(22, 3, 1)]
        [TestCase(13, 0, 0.002)]
        [TestCase(-1, 4, 0.1)] //Attention
        [Test]
        public void Sqrtn_ValuePowerEpsilon_ArgumentException(double number, int power, double epsilon)
        {
            Assert.That(() => NSqrt(number, power, epsilon), Throws.TypeOf<ArgumentException>());
        }
    }
}

/* Memory
 
public static string Sqrt(long number, int precision = 1)
{
    number = Math.Abs(number);
    var iteration = 0;
    var baseNumber = 1M;
    while (iteration != 30)
    {
        var local = baseNumber;
        baseNumber = (decimal) 0.5*(baseNumber + number/baseNumber);
        var range = 0M;
        if (baseNumber != local)
            range = local - baseNumber;
        if (range < (decimal) Math.Pow(10, -1*precision) && iteration > 3)
            // We need min 3 iterations for normal result.
            return Math.Round(local, precision).ToString(); // For more accurate testing.

        iteration++;
    }
    return Math.Round(baseNumber, precision).ToString(); // Here too.
}
[TestCase(-9, 2, "3.00")]
[TestCase(8, 2, "2.83")]
[TestCase(13, 1, "3.6")]
[TestCase(8, 9, "2.828427125")]
[TestCase(135587, 23, "368.22140079033972411077021")]// Here we need strings because this attribute can't work with decimals, inly with doubles.
//calc 368.2214007903397241107702(05)->1      7682
public void Sqrt_NumberWithPrecision_ExpectedNumber(long number, int precision, string expected)
{
    string result = Sqrt(number, precision);

    Assert.AreEqual(expected,result);       
}
*/