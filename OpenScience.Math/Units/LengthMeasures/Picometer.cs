namespace OpenScience.Math.Units.LengthMeasures
{
    public class Picometer : BaseLengthMeasure
    {
        public Picometer() { }

        public Picometer(double value) : base(value) { }

        public override double ConversionFactor { get { return System.Math.Pow(10,15); } }

        public override string Abbreviation { get { return "pm"; } }
    }
}
