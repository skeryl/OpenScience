using OpenScience.Math.Units.DerivedUnits.VolumeMeasures;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;

namespace OpenScience.Math.Units.DerivedUnits.DensityMeasures
{
    public class KilogramPerCubicKilometer : Density<Kilogram, Kilometer>
    {
        public KilogramPerCubicKilometer(){}

        public KilogramPerCubicKilometer(double value) : base(value) { }

    }
}
