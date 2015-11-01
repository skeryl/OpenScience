namespace OpenScience.Math.Units.TimeMeasures
{
    public class Minute : NumericValue<Time>
    {
        public Minute(){}

        public Minute(double value) : base(value) { }

        public override double ConversionFactor { get { return (1/60); } }

        public override string Abbreviation { get { return "m"; } }
    }
}
