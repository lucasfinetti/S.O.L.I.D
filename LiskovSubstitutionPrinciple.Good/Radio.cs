using LiskovSubstitutionPrinciple.Good.Base;

namespace LiskovSubstitutionPrinciple.Good
{
    public class Radio : Electrodomestic
    {
        public int NumberOfFrequencies { get; set; }

        public Radio() : base("Radio")
        {
            NumberOfFrequencies = 10;
        }
    }
}
