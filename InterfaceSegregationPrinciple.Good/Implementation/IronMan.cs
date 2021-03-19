using InterfaceSegregationPrinciple.Good.Interfaces.SuperHeros;

namespace InterfaceSegregationPrinciple.Good.Implementation
{
    public sealed class IronMan : IIronMan
    {
        public void Fight()
        {
            // Fight function
        }

        public void Fly()
        {
            // Fly function
        }

        public void Shoot()
        {
            // Shoot function
        }
    }
}
