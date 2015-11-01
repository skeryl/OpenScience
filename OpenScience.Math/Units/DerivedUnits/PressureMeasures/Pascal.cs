using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.DerivedUnits.PressureMeasures
{
    // equivalent to Newtons / Sq Meter
    public class Pascal : Pressure<Kilogram, Meter, Second, Meter>
    {
        public Pascal() { }
        public Pascal(double value) : base(value) { }
    }
}
