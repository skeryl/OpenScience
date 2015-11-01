namespace OpenScience.Math.Units.MassMeasures
{
    public class Gram : NumericValue<Mass>
    {
        public Gram(){}

        public Gram(double value) : base(value){}

        public override double ConversionFactor
        {
            get { return 1000; }
        }

        public override string Abbreviation
        {
            get { return "g"; }
        }
    }
}
