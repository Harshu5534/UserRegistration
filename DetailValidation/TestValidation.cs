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
            string Email1 = validation.ValidateEmail("harshal.patil2796@gmail.co.in");
            Assert.AreEqual(Email1, "harshal.patil2796@gmail.co.in");
            string Email2 = validation.ValidateEmail("abc@yahoo.com");
            Assert.AreEqual(Email2, "abc@yahoo.com");
            string Email3 = validation.ValidateEmail("abc-100@yahoo.com");
            Assert.AreEqual(Email3, "abc-100@yahoo.com");
            string Email4 = validation.ValidateEmail("abc.100@yahoo.com");
            Assert.AreEqual(Email4, "abc.100@yahoo.com");
            string Email5 = validation.ValidateEmail("abc111@abc.com");
            Assert.AreEqual(Email5, "abc111@abc.com");
            string Email6 = validation.ValidateEmail("abc-100@abc.net");
            Assert.AreEqual(Email6, "abc-100@abc.net");
            string Email7 = validation.ValidateEmail("abc.100@abc.com.au");
            Assert.AreEqual(Email7, "abc.100@abc.com.au");
            string Email8 = validation.ValidateEmail("abc@1.com");
            Assert.AreEqual(Email8, "abc@1.com");
            string Email9 = validation.ValidateEmail("abc@gmail.com.com");
            Assert.AreEqual(Email9, "abc@gmail.com.com");
            string Email10 = validation.ValidateEmail("abc+100@gmail.com");                                                                                                      
            Assert.AreEqual(Email10, "abc+100@gmail.com");
        }
        [Test]
        public void GivenInputIsString_WhenTestMobileNumber_ShouldReturnMobileNumber()
        {
            Validation validation = new Validation();
            string actual = validation.ValidateMobileNumber("+91 9158719379");
            Assert.AreEqual(actual, "+91 9158719379");
        }
        [Test]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword()
        {
            Validation validation = new Validation();
            string actual = validation.ValidatePassword("Harshupa2@");
            Assert.AreEqual(actual, "Harshupa2@");
        }
    }
}