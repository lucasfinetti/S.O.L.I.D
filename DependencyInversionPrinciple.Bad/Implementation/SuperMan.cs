using DependencyInversionPrinciple.Bad.Interfaces;

namespace DependencyInversionPrinciple.Bad.Implementation
{
    public sealed class SuperMan : ISuperHero
    {
        public void Fight()
        {
            // Fight function
        }

        public void Fly()
        {
            // Fly function
        }

        public void Run()
        {
            // Run function
        }

        public void Shoot()
        {
            // Shoot function
        }
    }
}