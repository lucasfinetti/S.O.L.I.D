using LiskovSubstitutionPrinciple.Bad.Base;
using System;

namespace LiskovSubstitutionPrinciple.Bad
{
    public sealed class CaptainAmerica : SuperHero
    {
        public override void Fly()
        {
            throw new Exception("Captain does not fly");
        }
    }
}
