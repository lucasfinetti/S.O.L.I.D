namespace LiskovSubstitutionPrinciple.Good.Base
{
    public class Electrodomestic
    {
        public string Name { get; set; }
        public bool On { get; set; }

        public Electrodomestic(string name)
        {
            On = false;
            Name = name;
        }

        public void TurnOnOrOff()
        {
            On = !On;
        }
    }
}
