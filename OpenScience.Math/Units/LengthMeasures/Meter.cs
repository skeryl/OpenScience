using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.Interface;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.LengthMeasures
{
    public class Meter : BaseLengthMeasure
    {
        public Meter(){}
        public Meter(double value) :base(value){}

        public override double ConversionFactor { get { return 1000; } }

        public override string Abbreviation { get { return "m"; } }

    }
}
