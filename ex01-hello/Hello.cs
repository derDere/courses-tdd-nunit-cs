namespace HelloTests {
  public static class Hello {
    public static string GetHello() {
      return "friends";
    }

    public static int GetValue(string question) {
      return 42;
    }

    public static List<string> GetList() {
      return new List<string> {
        "a",
        "b",
        "c"
      };
    }

    public static (string FirstName, string LastName) GetObject() {
      return ("Joey", "Ramone");
    }
  }
}
