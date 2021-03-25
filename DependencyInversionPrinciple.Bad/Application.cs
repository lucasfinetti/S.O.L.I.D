using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Bad
{
    public class Application
    {
        private Domain _domain;

        public Application()
        {
            _domain = new Domain();
        }

        public void DoSomething()
        {
            _domain.DoSomething();
        }
    }
}
