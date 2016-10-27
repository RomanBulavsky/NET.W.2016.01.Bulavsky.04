using static Logic.NewtonSqrt;
using NUnit.Framework;

namespace Logic.NUnit.Tests
{
    [TestFixture]
    public class NewtonSqrtTests
    {
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
    }
}
