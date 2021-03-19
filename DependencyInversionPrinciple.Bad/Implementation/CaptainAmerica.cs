using DependencyInversionPrinciple.Bad.Interfaces;
using System;

namespace DependencyInversionPrinciple.Bad.Implementation
{
    public sealed class CaptainAmerica : ISuperHero
    {
        public void Fight()
        {
            // Fight function
        }

        public void Fly()
        {
            throw new Exception("Captain does not fly");
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
