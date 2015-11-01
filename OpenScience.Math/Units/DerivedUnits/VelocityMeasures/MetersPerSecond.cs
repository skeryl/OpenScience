using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.DerivedUnits.VelocityMeasures
{
    public class MetersPerSecond : Velocity<Meter, Second>
    {
        public MetersPerSecond(){}
        public MetersPerSecond(double value) : base(value) { }
    }
}
