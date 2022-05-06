using NUnit.Framework;

namespace Sumator.Tests
{
    public class SumatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_TwoPossitiveNumbers()
        {
            long result = Sumator.Sum(new int[] { 5, 7});
            long expected = 12;
            Assert.That(result == expected);
        }


        [Test]
        public void Test_TwoNegativeNumbers()
        {
            long result = Sumator.Sum(new int[] { -5, -7 });
            long expected = -12;
            Assert.That(result == expected);
        }

        [Test]
        public void Test_OneNegativeAndOnePositiveNumbers()
        {
            long result = Sumator.Sum(new int[] { -5, 7 });
            long expected = 2;
            Assert.That(result == expected);
        }

        [Test]
        public void Test_OnePositiveNumber()
        {
            long result = Sumator.Sum(new int[] {  7 });
            long expected = 7;
            Assert.That(result == expected);
        }

        [Test]
        public void Test_EmptyArray()
        {
            long result = Sumator.Sum(new int[] {});
            long expected = 0;
            Assert.That(result == expected);
        }

        [Test]
        public void Test_BigValue()
        {
            long result = Sumator.Sum(new int[] { 2000000000, 2000000000, 2000000000 });
            long expected = 6000000000;
            Assert.AreEqual(expected, 6000000000);
        }
    }
}