using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloResults {
  public class HelloResultsTest {

    [Test]
    public void GetOList_ShouldReturnList() {
      // Arrange
      int age;

      // Act
      bool result = HelloResults.GetOAge(out age);

      // Expected
      const int expected = 99;

      // Assert
      Assert.IsTrue(result);
      Assert.AreEqual(expected, age);

      // Assert New
      Assert.That(result, Is.True);
      Assert.That(age, Is.EqualTo(expected));
    }

    [Test]
    public void GetNList_ShouldReturnList() {
      // Arrange
      int? age = HelloResults.GetNAge();

      // Expected
      const int expected = 99;

      // Assert
      Assert.IsTrue(age.HasValue);
      Assert.AreEqual(expected, age ?? -1);

      // Assert New
      Assert.That(age.HasValue, Is.True);
      Assert.That(age, Is.EqualTo(expected));
    }
  }
}
