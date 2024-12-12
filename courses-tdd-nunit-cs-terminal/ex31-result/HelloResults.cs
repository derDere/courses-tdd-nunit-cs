using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloResults {
  public static class HelloResults {

    public static bool GetOAge(out int age) {
      age = 99;
      return true;
    }

    public static int? GetNAge() {
      return 99;
    }

  }
}
