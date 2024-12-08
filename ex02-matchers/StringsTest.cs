using NUnit.Framework;
using StringsLibrary;
using System.Text.RegularExpressions;

namespace StringsTests
{
    public class StringsTests
    {
        [Test]
        [Ignore("TODO: Verify that `MyEmail` is a string")]
        public void MyEmailIsString()
        {
            Assert.IsInstanceOf<string>(Strings.MyEmail);
        }

        [Test]
        [Ignore("TODO: Verify that `MyEmail` starts with 'andreas'")]
        public void MyEmailStartsWithAndreas()
        {
            StringAssert.StartsWith("andreas", Strings.MyEmail);
        }

        [Test]
        [Ignore("TODO: Verify that `MyEmail` ends with '.eu'")]
        public void MyEmailEndsWithDotEu()
        {
            StringAssert.EndsWith(".eu", Strings.MyEmail);
        }

        [Test]
        [Ignore("TODO: Verify that `MyEmail` does NOT end with '.com'")]
        public void MyEmailDoesNotEndWithDotCom()
        {
            StringAssert.DoesNotEndWith(".com", Strings.MyEmail);
        }

        [Test]
        [Ignore("TODO: Verify that `MyEmail` includes 'binary'")]
        public void MyEmailIncludesBinary()
        {
            StringAssert.Contains("binary", Strings.MyEmail);
        }

        [Test]
        [Ignore("TODO: Verify that `MyEmail` includes 'andreas' and 'stars'")]
        public void MyEmailIncludesAndreasAndStars()
        {
            Assert.Multiple(() =>
            {
                StringAssert.Contains("andreas", Strings.MyEmail);
                StringAssert.Contains("stars", Strings.MyEmail);
            });
        }

        [Test]
        [Ignore("TODO: Verify that `MyEmail` matches the regex `/[a-z.-]{1,}@[a-z-]{1,}.[a-z]{2,}/`")]
        public void MyEmailMatchesRegex()
        {
            var regex = new Regex(@"[a-z.-]{1,}@[a-z-]{1,}\.[a-z]{2,}");
            Assert.IsTrue(regex.IsMatch(Strings.MyEmail));
        }

        [Test]
        [Ignore("TODO: Verify that `MyEmail` does NOT match the regex `/[a-z.-]{1,}@[a-z-]{1,}.[a-z]{3,}/`")]
        public void MyEmailDoesNotMatchRegex()
        {
            var regex = new Regex(@"[a-z.-]{1,}@[a-z-]{1,}\.[a-z]{3,}");
            Assert.IsFalse(regex.IsMatch(Strings.MyEmail));
        }

        [Test]
        [Ignore("TODO: Verify that `MyColor` is hexadecimal")]
        public void MyColorIsHexadecimal()
        {
            var regex = new Regex(@"^#[0-9A-Fa-f]{3,6}$");
            Assert.IsTrue(regex.IsMatch(Strings.MyColor));
        }
    }
}
