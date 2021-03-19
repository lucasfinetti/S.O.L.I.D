using InterfaceSegregationPrinciple.Good.Interfaces.Base;

namespace InterfaceSegregationPrinciple.Good.Interfaces.SuperHeros
{
    public interface IIronMan : ISuperHero, IFly, IShoot
    {
    }
}
