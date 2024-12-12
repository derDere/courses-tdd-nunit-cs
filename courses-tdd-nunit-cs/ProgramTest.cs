using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloTests {
  public class ProgramTest {
    [Test]
    public void TestMain() {
      // Act
      int result = courses_tdd_nunit_cs_terminal.Program.Main(new string[] { });

      // Assert
      const int expected = 0;
      Assert.AreEqual(expected, result);
    }
  }
}
