namespace OpenScience.Math.Units.MassMeasures
{
    public class Milligram : NumericValue<Mass>
    {
        public Milligram(){}

        public Milligram(double value) : base(value){}

        public override double ConversionFactor
        {
            get { return (1000 * 1000); }
        }

        public override string Abbreviation
        {
            get { return "mg"; }
        }
    }
}
