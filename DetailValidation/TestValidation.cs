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
    }
}