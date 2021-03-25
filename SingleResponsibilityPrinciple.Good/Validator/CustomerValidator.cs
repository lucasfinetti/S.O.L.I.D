namespace SingleResponsibilityPrinciple.Good.Validator
{
    public class CustomerValidator
    {
        private Customer _customer;

        public CustomerValidator(Customer customer)
        {
            _customer = customer;
        }

        public bool IsValid()
        {
            return _customer.Address != null && !string.IsNullOrEmpty(_customer.Name);
        }
    }
}
