using LiskovSubstitutionPrinciple.Good.Base;

namespace LiskovSubstitutionPrinciple.Good
{
    public class Television : Electrodomestic
    {
        public int NumberOfChannels { get; set; }

        public Television() : base("Television")
        {
            NumberOfChannels = 20;
        }
    }
}
