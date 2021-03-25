using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Bad
{
    public class Presentation
    {
        private Application _application;

        public Presentation()
        {
            _application = new Application();
        }

        public void DoSomething()
        {
            _application.DoSomething();
        }
    }
}
