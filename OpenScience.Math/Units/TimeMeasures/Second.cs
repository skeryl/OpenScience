namespace OpenScience.Math.Units.TimeMeasures
{
    public class Second : NumericValue<Time>
    {
        public Second(){}

        public Second(double value) : base(value) { }

        public override double ConversionFactor { get { return 1; } }

        public override string Abbreviation { get { return "s"; } }
    }
}
