using System;

namespace SingleResponsibilityPrinciple.Good
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
