using NUnit.Framework;
using System.Collections.Generic;
using PeopleLibrary;

namespace PeopleTests
{
    public class PeopleTests
    {
        private List<Person> _people;

        [SetUp]
        public void Setup()
        {
            _people = PeopleProvider.GetPeople();
        }

        [Test]
        public void Init_ShouldHaveCorrectSize()
        {
            Assert.IsNotNull(_people);
            Assert.AreEqual(1000, _people.Count);
        }

        [Test]
        [Ignore("TODO: Should verify that person at index 23 has firstName 'Kim'")]
        public void VerifyPersonAtIndex23HasFirstNameKim()
        {
            var person = _people[23];
            Assert.AreEqual("Kim", person.FirstName);
        }

        [Test]
        [Ignore("TODO: Should verify that person at index 23 contains fields 'id' and 'ipAddress'")]
        public void VerifyPersonAtIndex23ContainsFields()
        {
            var person = _people[23];
            Assert.IsNotNull(person.Id);
            Assert.IsNotNull(person.IpAddress);
        }

        [Test]
        [Ignore("TODO: Should verify that person at index 23 contains specific values")]
        public void VerifyPersonAtIndex23ContainsValues()
        {
            var person = _people[23];
            Assert.AreEqual("55.247.214.105", person.IpAddress);
            Assert.AreEqual("Rawcliffe", person.LastName);
        }
    }
}
