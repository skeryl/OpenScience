namespace OpenScience.Math.Units.LengthMeasures
{
    public class Centimeter : BaseLengthMeasure
    {
        public Centimeter(){}

        public Centimeter(double value) : base(value) { }

        public override double ConversionFactor { get { return 100000; } }

        public override string Abbreviation { get { return "cm"; } }
    }
}
