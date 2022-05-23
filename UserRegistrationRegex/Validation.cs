using System.Text.RegularExpressions;

namespace UserRegistrationRegex
{
    public class Validation
    {                                                                                                       
        public const string FIRSTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public const string LASTNAME_REGEX = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static string EMAIL_REGEX = "^[0-9a-zA-Z]+[.+-_]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        public static string MOBILENUMBER_REGEX = "^[+]{1}[1-9]{2}[-. ]{1}[1-9]{2}[0-9]{8}$";
        public static string PASSWORD_REGEX = "^[#@%!]{1}+[a-zA-z0-9]{8,}$";
        private string message;

        public Validation(string message)
        {
            this.message = message;
        }
        public bool ValidateFirstName(string firstname)
        {
            try
            {
                if (FIRSTNAME_REGEX != firstname)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_FIRSTNAME, "First Name Is Invalid");
                }
                return Regex.IsMatch(firstname, FIRSTNAME_REGEX);
            }
            catch (ExceptionUserRegistration ex)
            {
                return ex.Message == "First Name Is Invalid";
            }
        }
        public bool ValidateLastName(string lastname)
        {
            try
            {
                if (LASTNAME_REGEX != lastname)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_LASTNAME, "Last Name Is Invalid");
                }
                return Regex.IsMatch(lastname, LASTNAME_REGEX);
            }
            catch(ExceptionUserRegistration ex)
            {
                return ex.Message == "Last Name Is Invalid";
            }
        }
        public bool ValidateEmail(string email)
        {
            try
            {
                if (EMAIL_REGEX != email)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_EMAIL, "Email Is Invalid");
                }
                return Regex.IsMatch(email, EMAIL_REGEX);
            }
            catch (ExceptionUserRegistration ex)
            {
                return ex.Message == "Email Is Invalid";
            }
        }
        public bool ValidateMobileNumber(string mobilenumber)
        {
            try
            {
                if (MOBILENUMBER_REGEX != mobilenumber)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_MOBILENUMBER, "Mobile Number Is Invalid");
                }
                return Regex.IsMatch(mobilenumber, MOBILENUMBER_REGEX);
            }
            catch (ExceptionUserRegistration ex)
            {
                return ex.Message == "Mobile Number Is Invalid";
            }
        }
        public bool ValidatePassword(string password)
        {
            try
            {
                if (PASSWORD_REGEX != password)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_PASSWORD, "Passowrd Is Invalid");
                }
                return Regex.IsMatch(password, PASSWORD_REGEX);
            }
            catch (ExceptionUserRegistration ex)
            {
                return ex.Message == "Password Is Invalid";
            }
        }
        public bool ValidateEmailParametrized(string email)
        {
            try
            {
                if (EMAIL_REGEX != email)
                {
                    throw new ExceptionUserRegistration(ExceptionUserRegistration.ExceptionType.INVALID_EMAIL, "Email Is Invalid");
                }
                return Regex.IsMatch(email, EMAIL_REGEX);
            }
            catch (ExceptionUserRegistration ex)
            {
                return ex.Message == "Email Is Invalid";
            }
        }
    }
}