using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static Logic.DoubleExtension;

namespace Logic.NUnit.Tests
{
    [TestFixture]
    class DoubleExtensionTests
    {
        [TestCase(1.0,         "0011111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(-1.0,        "1011111111110000000000000000000000000000000000000000000000000000")]
        [TestCase(-2.0,        "1100000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(2.0,         "0100000000000000000000000000000000000000000000000000000000000000")]
        [TestCase(5,           "0100000000010100000000000000000000000000000000000000000000000000")]
        [TestCase(-5.0,        "1100000000010100000000000000000000000000000000000000000000000000")]
        [TestCase(17.84333123, "0100000000110001110101111110010010001110001101001000101110100011")]
        //                     "0100000000110001110101111110010010001110001101001000101110100011" http://www.binaryconvert.com/result_double.html?decimal=049055046056052051051051049050051
        public void Sqrt_NumberWithPrecision_ExpectedNumber(double number, string expected)
        {
            string result = number.ShowIn754();
            Debug.WriteLine(result);
            Assert.AreEqual(expected, result);
        }

    }
}
