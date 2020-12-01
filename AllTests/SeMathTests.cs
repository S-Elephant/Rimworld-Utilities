using NUnit.Framework;
using SquirtingElephant.Helpers;

namespace AllTests
{
    public class SeMathTests
    {
        [Test]
        public void RoundToNearestMultiple()
        {
            Assert.AreEqual(9, SeMath.RoundToNearestMultiple(10, 3));
            Assert.AreEqual(12, SeMath.RoundToNearestMultiple(11, 3));
            Assert.AreEqual(-9, SeMath.RoundToNearestMultiple(-8, 3));
            Assert.AreEqual(-12, SeMath.RoundToNearestMultiple(-11, 3));
        }

        [Test]
        public void CalcColumn_X()
        {
            Assert.AreEqual(27f, SeMath.CalcColumn_X(15f, 10f, 2f, 1));
            Assert.AreEqual(15f, SeMath.CalcColumn_X(15f, 10f, 2f, 0));
            Assert.AreEqual(39f, SeMath.CalcColumn_X(15f, 10f, 2f, 2));
        }
    }
}