using DependencyInversionPrinciple.Good.Interfaces;

namespace DependencyInversionPrinciple.Good.Implementation
{
    public class Application : IApplication
    {
        private IDomain _domain;

        public Application(IDomain domain)
        {
            _domain = domain;
        }

        public void DoSomething()
        {
            _domain.DoSomething();
        }
    }
}
