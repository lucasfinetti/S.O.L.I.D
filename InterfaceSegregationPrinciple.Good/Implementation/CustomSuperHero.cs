using InterfaceSegregationPrinciple.Good.Interfaces;
using InterfaceSegregationPrinciple.Good.Interfaces.Base;

namespace InterfaceSegregationPrinciple.Good.Implementation
{
    public sealed class CustomSuperHero : ISuperHero, IFly, IThunder
    {
        public void Fight()
        {
            // Fight function
        }

        public void Fly()
        {
            // Fly function
        }

        public void Thunder()
        {
            // Thunder function
        }
    }
}
