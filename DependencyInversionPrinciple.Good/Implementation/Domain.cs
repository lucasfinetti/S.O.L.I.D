using DependencyInversionPrinciple.Good.Interfaces;

namespace DependencyInversionPrinciple.Good.Implementation
{
    public class Domain : IDomain
    {
        private IDataAccess _dataAccess;

        public Domain(IDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        
        public void DoSomething()
        {
            _dataAccess.DoSomething();
        }
    }
}
