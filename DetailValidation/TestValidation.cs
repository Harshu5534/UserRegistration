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
        [Test]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateEmail("harshal.patil2796@gmail.co.in");
            Assert.AreEqual(actual, "harshal.patil2796@gmail.co.in");
        }
        [Test]
        public void GivenInputIsString_WhenTestMobileNumber_ShouldReturnMobileNumber()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateMobileNumber("+91 9158719379");
            Assert.AreEqual(actual, "+91 9158719379");
        }
    }
}