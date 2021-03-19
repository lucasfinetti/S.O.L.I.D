using DependencyInversionPrinciple.Good.Interfaces.Base;

namespace DependencyInversionPrinciple.Good.Interfaces.SuperHeros
{
    public interface ISuperMan : ISuperHero, IFly, IRun, IShoot
    {
    }
}
