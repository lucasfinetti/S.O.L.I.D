using InterfaceSegregationPrinciple.Bad.Interfaces;
using System;

namespace InterfaceSegregationPrinciple.Bad.Implementation
{
    public sealed class IronMan : ISuperHero
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
            throw new Exception("Iron man isn't very fast running");
        }

        public void Shoot()
        {
            // Shoot function
        }
    }
}