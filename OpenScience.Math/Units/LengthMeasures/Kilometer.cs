namespace OpenScience.Math.Units.LengthMeasures
{
    public class Kilometer : BaseLengthMeasure
    {
        public Kilometer(){}

        public Kilometer(double value):base(value){}

        public override double ConversionFactor { get { return 1; } }

        public override string Abbreviation { get { return "km"; } }
    }
}
