using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.DerivedUnits.VelocityMeasures
{
    public class KilometersPerHour : Velocity<Kilometer, Hour>
    {
        public KilometersPerHour(){}
        public KilometersPerHour(double value) : base(value) { }
    }
}
