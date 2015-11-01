namespace OpenScience.Math.Units.CurrentMeasures
{
    public class Ampere : NumericValue<Current>
    {
        public Ampere(){}

        public Ampere(double value) : base(value) { }

        public override double ConversionFactor
        {
            get { return 1; }
        }

        public override string Abbreviation
        {
            get { return "A"; }
        }
    }
}
