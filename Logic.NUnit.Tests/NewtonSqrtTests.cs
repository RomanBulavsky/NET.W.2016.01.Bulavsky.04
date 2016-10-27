using System.Diagnostics;
using static Logic.NewtonSqrt;
using NUnit.Framework;

namespace Logic.NUnit.Tests
{
    [TestFixture]
    public class NewtonSqrtTests
    {
        [TestCase(9, 2, 3.0)]
        [TestCase(8, 2, 2.83)]
        [TestCase(13, 1, 3.6)]
        [TestCase(8, 9, 2.828427125)]
        public void Sqrt_NumberWithPrecision_ExpectedNumber(long number, int precision, decimal expected)
        {
            decimal result = Sqrt(number, precision);
            Debug.WriteLine(result);
            Assert.AreEqual(expected,result);       
        }
    }
}
