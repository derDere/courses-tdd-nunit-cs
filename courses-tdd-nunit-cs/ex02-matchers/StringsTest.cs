using NUnit.Framework;
using StringsLibrary;
using System.Text.RegularExpressions;

namespace StringsTests
{
    public class StringsTests
    {
        [Test]
        //[Ignore("TODO: Verify that `MyEmail` is a string")]
        public void MyEmailIsString()
        {
            Assert.IsInstanceOf<string>(Strings.MyEmail);

            Assert.That(Strings.MyEmail, Is.TypeOf<string>());
        }

        [Test]
        //[Ignore("TODO: Verify that `MyEmail` starts with 'andreas'")]
        public void MyEmailStartsWithAndreas()
        {
            StringAssert.StartsWith("andreas", Strings.MyEmail);

            Assert.That(Strings.MyEmail, Does.StartWith("andreas").IgnoreCase);
        }

        [Test]
        //[Ignore("TODO: Verify that `MyEmail` ends with '.eu'")]
        public void MyEmailEndsWithDotEu()
        {
            StringAssert.EndsWith(".eu", Strings.MyEmail);

            Assert.That(Strings.MyEmail, Does.EndWith(".eu").IgnoreCase);
        }

        [Test]
        //[Ignore("TODO: Verify that `MyEmail` does NOT end with '.com'")]
        public void MyEmailDoesNotEndWithDotCom()
        {
            StringAssert.DoesNotEndWith(".com", Strings.MyEmail);
            
            Assert.That(Strings.MyEmail, Does.Not.EndWith(".com").IgnoreCase);
        }

        [Test]
        //[Ignore("TODO: Verify that `MyEmail` includes 'binary'")]
        public void MyEmailIncludesBinary()
        {
            StringAssert.Contains("binary", Strings.MyEmail);

            Assert.That(Strings.MyEmail, Does.Contain("binary").IgnoreCase);
        }

        [Test]
        //[Ignore("TODO: Verify that `MyEmail` includes 'andreas' and 'stars'")]
        public void MyEmailIncludesAndreasAndStars()
        {
            Assert.Multiple(() =>
            {
                StringAssert.Contains("andreas", Strings.MyEmail);
                StringAssert.Contains("stars", Strings.MyEmail);
            });

            Assert.That(Strings.MyEmail, Does.Contain("andreas").And.Contain("stars").IgnoreCase);
        }

        [Test]
        //[Ignore("TODO: Verify that `MyEmail` matches the regex `/[a-z.-]{1,}@[a-z-]{1,}.[a-z]{2,}/`")]
        public void MyEmailMatchesRegex()
        {
            Regex regex = new(@"[a-z.-]{1,}@[a-z-]{1,}\.[a-z]{2,}");
            Assert.IsTrue(regex.IsMatch(Strings.MyEmail));

            Assert.That(Strings.MyEmail, Does.Match(@"[a-z.-]{1,}@[a-z-]{1,}\.[a-z]{2,}").IgnoreCase);
        }

        [Test]
        //[Ignore("TODO: Verify that `MyEmail` does NOT match the regex `/[a-z.-]{1,}@[a-z-]{1,}.[a-z]{3,}/`")]
        public void MyEmailDoesNotMatchRegex()
        {
            Regex regex = new(@"[a-z.-]{1,}@[a-z-]{1,}\.[a-z]{3,}");
            Assert.IsFalse(regex.IsMatch(Strings.MyEmail));

            Assert.That(Strings.MyEmail, Does.Not.Match(@"[a-z.-]{1,}@[a-z-]{1,}\.[a-z]{3,}").IgnoreCase);
        }

        [Test]
        //[Ignore("TODO: Verify that `MyColor` is hexadecimal")]
        public void MyColorIsHexadecimal()
        {
            Regex regex = new(@"^#[0-9A-Fa-f]{3,6}$");
            Assert.IsTrue(regex.IsMatch(Strings.MyColor));

            Assert.That(Strings.MyColor, Does.Match(@"^#[0-9A-Fa-f]{3,6}$"));
        }
    }
}
