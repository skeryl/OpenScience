namespace OpenScience.Math.Units.TimeMeasures
{
    public class Millisecond : NumericValue<Time>
    {
        public Millisecond(){}

        public Millisecond(double value) : base(value) { }

        public override double ConversionFactor { get { return 1000; } }

        public override string Abbreviation { get { return "ms"; } }
    }
}
