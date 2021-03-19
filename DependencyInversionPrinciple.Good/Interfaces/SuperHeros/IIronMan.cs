using DependencyInversionPrinciple.Good.Interfaces.Base;

namespace DependencyInversionPrinciple.Good.Interfaces.SuperHeros
{
    public interface IIronMan : ISuperHero, IFly, IShoot
    {
    }
}
