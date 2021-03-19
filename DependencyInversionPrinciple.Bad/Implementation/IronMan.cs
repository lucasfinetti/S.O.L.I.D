using DependencyInversionPrinciple.Bad.Interfaces;
using System;

namespace DependencyInversionPrinciple.Bad.Implementation
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
            throw new Exception("Iron man is not very fast running");
        }

        public void Shoot()
        {
            // Shoot function
        }
    }
}