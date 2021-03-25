using DependencyInversionPrinciple.Good.Interfaces;

namespace DependencyInversionPrinciple.Good.Implementation
{
    public class Presentation : IPresentation
    {
        private IApplication _application;

        public Presentation(IApplication application)
        {
            _application = application;
        }

        public void DoSomething()
        {
            _application.DoSomething();
        }
    }
}
