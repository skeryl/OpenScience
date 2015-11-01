using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.DerivedUnits.ForceMeasures
{
    public class Newton : Force<Kilogram, Meter, Second>
    {
        public Newton() { }
        public Newton(double value) :base(value) { }
    }
}
