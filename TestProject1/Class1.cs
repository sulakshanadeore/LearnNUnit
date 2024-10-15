using NUnitDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    [TestFixture(typeof(Staff))]
    [TestFixture(typeof(Student))]
    public class GetFullNameTests<T> where T : IPerson, new()
    {
        [Test]
        public void FullNameContainsFirstAndLastName()
        {
            // Arrange

            var person = new T
            {
                FirstName = "Narendra",
                LastName = "Modi"
            };

            // Act

            var fullName = person.GetFullName();

            // Assert

            Assert.That(fullName, Is.EqualTo("Narendra Modi"));
        }
    }
}
