using NUnit.Framework;
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
        }

        [Test]
        public void TestArrayWithExtendedMatchers()
        {
            // When
            var actual = Arrays.GetList();

            // Then
            Assert.IsNotNull(actual);
            Assert.AreEqual(3, actual.Count, "Expected array to have a size of 3");
        }

        [Test]
        [Ignore("TODO: Should verify that GetList yields an array that includes 'a' and 'c'")]
        public void VerifyGetListIncludesSpecificItems()
        {
            // When
            var actual = Arrays.GetList();

            // Then
            Assert.Contains("a", actual);
            Assert.Contains("c", actual);
        }
    }
}
