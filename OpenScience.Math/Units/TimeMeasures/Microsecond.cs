namespace OpenScience.Math.Units.TimeMeasures
{
    public class Microsecond : NumericValue<Time>
    {
        public Microsecond(){}

        public Microsecond(double value) : base(value) { }

        public override double ConversionFactor { get { return System.Math.Pow(10, 6); } }

        public override string Abbreviation { get { return "μs"; } }
    }
}
