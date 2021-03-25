using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionPrinciple.Bad
{
    public class Domain
    {
        private DataAccess _dataAccess;

        public Domain()
        {
            _dataAccess = new DataAccess();
        }

        public void DoSomething()
        {
            _dataAccess.DoSomething();
        }
    }
}
