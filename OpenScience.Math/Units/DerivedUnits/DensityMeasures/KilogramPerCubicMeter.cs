using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;

namespace OpenScience.Math.Units.DerivedUnits.DensityMeasures
{
    public class KilogramPerCubicMeter : Density<Kilogram, Meter>
    {
        public KilogramPerCubicMeter(){}
        public KilogramPerCubicMeter(double value) : base(value) {}
    }
}
