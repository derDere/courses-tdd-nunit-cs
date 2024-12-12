using NUnit.Framework;

namespace FibonacciNamespace
{
    public abstract class FibonacciTest {
        public FibonacciTest(Fibonacci fibonacci) {
            this.fibonacci = fibonacci;
        }

        public Fibonacci fibonacci;

        [Test]
        [TestCaseSource(nameof(GetFibonacciSequence))]
        public void Calc_shouldYieldCorrectly(int index, int expected) {
            // when
            int actual = fibonacci.Calc(index);

            // then
            Assert.AreEqual(expected, actual);
        }

        [Test]
        [TestCaseSource(nameof(GetInvalidFibonacciSequence))]
        public void Calc_shouldThrowExceptionWhenIndexIsNegative(int index) {
            // then
            Assert.Throws<ArgumentOutOfRangeException>(() => fibonacci.Calc(index));
        }

        public static object[] GetFibonacciSequence = {
            new object[] { 0, 0 },
            new object[] { 1, 1 },
            new object[] { 2, 1 },
            new object[] { 3, 2 },
            new object[] { 19, 4_181 }
        };

        public static object[] GetInvalidFibonacciSequence = {
            new object[] { -1 },
            new object[] { 47 }
        };
    }

    public class FibonacciLoopImplTest : FibonacciTest {
        public FibonacciLoopImplTest() : base(new FibonacciLoopImpl()) {}
    }
}