using InterfaceSegregationPrinciple.Good.Interfaces.Base;

namespace InterfaceSegregationPrinciple.Good.Interfaces.SuperHeros
{
    public interface ISuperMan : ISuperHero, IFly, IRun, IShoot
    {
    }
}
