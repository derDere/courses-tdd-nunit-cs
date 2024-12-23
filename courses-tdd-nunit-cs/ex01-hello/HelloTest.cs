using NUnit.Framework;
using NUnit.Framework.Internal;
using System.Collections.Generic;

namespace HelloTests {
  public class HelloTests {
    [Test]
    public void Hello_ShouldReturnFriends() {
      // Act
      var result = Hello.GetHello();

      // Assert
      Assert.AreEqual("friends", result);

      // Assert New
      Assert.That(result, Is.EqualTo("friends"));
      Assert.That(result, Is.Not.EqualTo("xxxx"));
    }

    [Test]
    //[Ignore("Test skipped, as requested in the original code")]
    public void GetValue_ShouldReturnAnswer() {
      // Arrange
      var input = "What's the meaning of it all?";

      // Act
      var actual = Hello.GetValue(input);

      // Assert
      const int expected = 42;
      Assert.AreEqual(expected, actual);
    }

    [Test]
    //[Ignore("Test skipped, as requested in the original code")]
    public void GetList_ShouldMatchExpectedItems() {
      // Act
      var actual = Hello.GetList();

      // Assert
      var expected = new List<string> {
        "a",
        "b",
        "c"
      };
      CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    //[Ignore("TODO")]
    public void GetObject_ShouldYieldExpectedUser() {
      // Act
      (string FirstName, string LastName) actual = Hello.GetObject();

      // Expected
      const string expectedFirstName = "Joey";
      const string expectedLastName = "Ramone";

      // Assert
      Assert.AreEqual(expectedFirstName, actual.FirstName);
      Assert.AreEqual(expectedLastName, actual.LastName);

      // Assert New
      Assert.That(actual.FirstName, Is.EqualTo(expectedFirstName));
      Assert.That(actual.LastName, Is.EqualTo(expectedLastName));
    }
  }
}
