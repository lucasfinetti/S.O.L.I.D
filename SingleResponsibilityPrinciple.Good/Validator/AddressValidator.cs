namespace SingleResponsibilityPrinciple.Good.Validator
{
    public class AddressValidator
    {
        private Address _address;

        public AddressValidator(Address address)
        {
            _address = address;
        }

        public bool IsValid()
        {
            // Imagine a validation here
            return !string.IsNullOrEmpty(_address.City);
        }
    }
}
