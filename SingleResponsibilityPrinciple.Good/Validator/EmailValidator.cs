using System.Text.RegularExpressions;

namespace SingleResponsibilityPrinciple.Good.Validator
{
    public class EmailValidator
    {
        private string _email;

        public EmailValidator(string email)
        {
            _email = email;
        }

        public bool IsValid()
        {
            return Regex.IsMatch(_email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
