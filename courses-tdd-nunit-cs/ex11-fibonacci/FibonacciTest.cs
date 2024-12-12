using NUnit.Framework;

namespace FibonacciNamespace
{
  public abstract class FibonacciTest {
    public FibonacciTest(Fibonacci fibonacci) {
      this.fibonacci = fibonacci;
    }

    public Fibonacci fibonacci;


    [Test]
    public void Calc_shouldYield0For0() {
      // given
      int index = 0;

      // when
      int actual = fibonacci.Calc(index);

      // then
      int expected = 0;
      Assert.AreEqual(expected, actual);
    }


    [Test]
    [Ignore("ToDo")]
    public void Calc_ShouldFailForMinus1() {
      // Arrange
      int index = -1;

      // Act
      ArgumentException e = Assert.Throws<ArgumentException>(() => fibonacci.Calc(index));      
      // Assert
      string expected = "Index must not be negative";
      Assert.That(e.Message, Is.EqualTo(expected));
    }


    [Test]
    [Ignore("ToDo")]
    public void Calc_ShouldFailFor47() {
    }
  }

  public class FibonacciLoopImplTest : FibonacciTest {
    public FibonacciLoopImplTest() : base(new FibonacciLoopImpl()) 
    {}

  }


}