using System;
using System.Text.RegularExpressions;

namespace SingleResponsibilityPrinciple.Bad
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public DateTime Birthdate { get; set; }

        public void SendEmail()
        {
            // Send Email Function
        }

        public bool EmailIsValid()
        {
            return Regex.IsMatch(this.Email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }
    }
}
