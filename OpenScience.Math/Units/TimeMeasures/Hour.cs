namespace OpenScience.Math.Units.TimeMeasures
{
    public class Hour : NumericValue<Time>
    {
        public Hour(){}

        public Hour(double value) : base(value) { }

        public override double ConversionFactor { get { return (1/((60)*60)); } }

        public override string Abbreviation { get { return "h"; } }
    }
}
