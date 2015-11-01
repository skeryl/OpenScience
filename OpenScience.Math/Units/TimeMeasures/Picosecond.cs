namespace OpenScience.Math.Units.TimeMeasures
{
    public class Picosecond : NumericValue<Time>
    {
        public Picosecond(){}

        public Picosecond(double value) : base(value) { }

        public override double ConversionFactor { get { return System.Math.Pow(10, 12); } }

        public override string Abbreviation { get { return "ns"; } }
    }
}
