using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetTranslatorGrafica;

namespace LeetTranslatorGraficaTests
{
    /// <summary>
    /// This class doesn't test all the alphabet
    /// </summary>
    [TestClass()]
    public class TranslatorTest
    {
        /// <summary>
        /// Test light-leet mode
        /// </summary>
        [TestMethod()]
        public void LightLeetTest()
        {
            string input, result, expected;

            input = "Hello World!";
            expected = "H3££0 W0r£d!";

            result = TranslatorOld.LightLeet(input);

            Assert.AreEqual(expected, result);
        }

        /// <summary>
        /// Test complete-leet mode
        /// </summary>
        [TestMethod()]
        public void CompleteLeetTest()
        {
            string input, result, expected;

            input = "Test complete leet!";
            expected = "73$7 [0[V]p£373 £337!";

            result = TranslatorOld.CompleteLeet(input);

            Assert.AreEqual(expected, result);
        }
    }
}