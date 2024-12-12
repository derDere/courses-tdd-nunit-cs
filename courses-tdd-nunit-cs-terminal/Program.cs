using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace courses_tdd_nunit_cs_terminal {
  public static class Program {
    public static int Main(string[] args) {
      Console.WriteLine("Hello, friends!");

      string input;
      do {
        input = "exit"; // Console.ReadLine();

        string hello = HelloTests.Hello.GetHello();
        int value = HelloTests.Hello.GetValue(input);
        List<string> myAbc = HelloTests.Hello.GetList();
        (string FirstName, string LastName) = HelloTests.Hello.GetObject();

        Console.WriteLine($"Hello, {hello}!");
        Console.WriteLine($"The value is {value}.");
        Console.WriteLine($"My ABC: {string.Join(", ", myAbc)}");
        Console.WriteLine($"My name is {FirstName} {LastName}.");

      } while (input != "exit");

      return 0;
    }
  }
}
