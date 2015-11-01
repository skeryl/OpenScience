namespace OpenScience.Math.Units.MassMeasures
{
    public class Kilogram : NumericValue<Mass>
    {
        public Kilogram(){}

        public Kilogram(double value) : base(value){}

        public override double ConversionFactor
        {
            get { return 1; }
        }

        public override string Abbreviation
        {
            get { return "kg"; }
        }
    }
}