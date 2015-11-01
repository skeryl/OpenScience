namespace OpenScience.Math.Units.TimeMeasures
{
    public class Nanosecond : NumericValue<Time>
    {
        public Nanosecond(){}

        public Nanosecond(double value) : base(value) { }

        public override double ConversionFactor { get { return System.Math.Pow(10, 9); } }

        public override string Abbreviation { get { return "ns"; } }
    }
}
