using NUnit.Framework;
using UserRegistrationRegex;

namespace DetailValidation
{
    public class TestValidation
    {
        [Test]
        public void GivenInputIsString_WhenTestFirstName_ShouldReturnFirstName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateFirstName("Harshal");
            Assert.AreEqual(actual, "Harshal");
        }
        [Test]
        public void GivenInputIsString_WhenTestLastName_ShouldReturnLastName()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateLastName("Patil");
            Assert.AreEqual(actual, "Patil");
        }
    }
}