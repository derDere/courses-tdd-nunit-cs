using courses_tdd_nunit_cs_terminal.Properties;
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
            string json = Resources.ppl;
            return JsonSerializer.Deserialize<List<Person>>(json);
        }
    }
}
