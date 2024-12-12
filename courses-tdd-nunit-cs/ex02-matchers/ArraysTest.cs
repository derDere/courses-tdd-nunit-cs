using NUnit.Framework;
using NUnit.Framework.Constraints;
using System.Collections.Generic;

namespace ArraysLibrary
{

  public class ArraysTests
    {
        [Test]
        public void TestArrayWithStandardMatchers()
        {
            // When
            var actual = Arrays.GetList();

            // Then
            var expected = new List<string> { "a", "b", "c" };
            CollectionAssert.AreEqual(expected, actual);
            Assert.AreEqual(3, actual.Count);

            // Then New

            // Ignoring whitespaces
            Assert.That(actual.Select( s => s.Trim() ), Is.EquivalentTo(expected));
            Assert.That(actual, Is.EquivalentTo(expected).IgnoreCase);
            Assert.That(actual.Count, Is.EqualTo(3));
        }

        [Test]
        public void TestArrayWithExtendedMatchers()
        {
            // When
            var actual = Arrays.GetList();

            // Then
            Assert.IsNotNull(actual);
            Assert.AreEqual(3, actual.Count, "Expected array to have a size of 3");

            // Then New
            Assert.That(actual, Is.Not.Null);
            Assert.That(actual.Count, Is.EqualTo(3), "Expected array to have a size of 3");
        }

        [Test]
        //[Ignore("TODO: Should verify that GetList yields an array that includes 'a' and 'c'")]
        public void VerifyGetListIncludesSpecificItems()
        {
            // When
            var actual = Arrays.GetList();

            // Then
            Assert.Contains("a", actual);
            Assert.Contains("c", actual);

            // Then New
            Assert.That(actual, Has.Member("a").And.Member("c"));
        }
    }
}
