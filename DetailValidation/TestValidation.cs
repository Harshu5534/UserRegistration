using NUnit.Framework;
using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using UserRegistrationRegex;

namespace DetailValidation
{
    public class TestValidation
    {
        [Test]
        public void GivenInputIsString_WhenTestFirstName_ShouldReturnFirstName()
        {
            try
            {
                Validation validation = new Validation("INVALID_FIRSTNAME");
                bool firstName = validation.ValidateFirstName("Harshal");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "First Name Is Invalid");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestLastName_ShouldReturnLastName()
        {
            try
            {
                Validation validation = new Validation("INVALID_LASTNAME");
                bool lastName = validation.ValidateFirstName("Patil");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "Last Name Is Invalid");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmail()
        {
            try
            {
                Validation validation = new Validation("INVALID_EMAIL");
                bool email1 = validation.ValidateEmail("harshal.patil2796@gmail.co.in");
                bool email2 = validation.ValidateEmail("abc@yahoo.com");
                bool email3 = validation.ValidateEmail("abc-100@yahoo.com"); 
                bool email4 = validation.ValidateEmail("abc.100@yahoo.com");
                bool email5 = validation.ValidateEmail("abc111@abc.com");
                bool email6 = validation.ValidateEmail("abc-100@abc.net");
                bool email7 = validation.ValidateEmail("abc.100@abc.com.au");
                bool email8 = validation.ValidateEmail("abc@1.com");
                bool email9 = validation.ValidateEmail("abc@gmail.com.com");
                bool email10= validation.ValidateEmail("abc+100@gmail.com");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "Email Is Invalid");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestMobileNumber_ShouldReturnMobileNumber()
        {
            try
            {
                Validation validation = new Validation("INVALID_MOBILENUMBER");
                bool mobileNumber = validation.ValidateMobileNumber("9158719379");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "Mobile Number Is Invalid");
            }
        }
        [Test]
        public void GivenInputIsString_WhenTestPassword_ShouldReturnPassword()
        {
            try
            {
                Validation validation = new Validation("INVALID_PASSWORD");
                bool password = validation.ValidatePassword("Harshupa2@");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "Password Is Invalid");
            }
        }
        [Test]
        [TestCase("Hello@welcome.com")]
        [TestCase("Hello+plus@welcome.com")]
        [TestCase("HarshuPatil@gmail.com.in")]
        [TestCase("Hello+123@welcome.com")]
        public void GivenInputIsString_WhenTestEmail_ShouldReturnEmailParamerizedTest(string mailAddress)
        {
            try
            {
                Validation validation = new Validation("INVALID_EMAIL");
                bool password = validation.ValidatePassword("mailAddress");
            }
            catch (ExceptionUserRegistration ex)
            {
                Assert.AreEqual(ex.Message, "Email Is Invalid");
            }
           
        }
    }
}