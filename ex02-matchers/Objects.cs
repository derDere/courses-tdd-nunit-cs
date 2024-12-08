using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PeopleLibrary
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string IpAddress { get; set; }
    }

    public static class PeopleProvider
    {
        public static List<Person> GetPeople()
        {
            var baseDirectory = AppContext.BaseDirectory;
            var projectRoot = Path.Combine(baseDirectory, "../../../ex02-matchers");
            var jsonFilePath = Path.Combine(projectRoot, "ppl.json");
            var json = File.ReadAllText(jsonFilePath);
            return JsonSerializer.Deserialize<List<Person>>(json);
        }
    }
}
