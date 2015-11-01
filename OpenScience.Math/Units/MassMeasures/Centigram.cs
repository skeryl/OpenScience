namespace OpenScience.Math.Units.MassMeasures
{
    public class Centigram : NumericValue<Mass>
    {
        public Centigram(){}

        public Centigram(double value):base(value){}

        public override double ConversionFactor
        {
            get { return 100000; }
        }

        public override string Abbreviation
        {
            get { return "cg"; }
        }
    }
}
