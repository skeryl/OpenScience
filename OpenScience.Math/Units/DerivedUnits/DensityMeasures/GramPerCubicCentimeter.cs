using OpenScience.Math.Units.DerivedUnits.VolumeMeasures;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;

namespace OpenScience.Math.Units.DerivedUnits.DensityMeasures
{
    public class GramPerCubicCentimeter : Density<Gram, Centimeter>
    {
        public GramPerCubicCentimeter(){}

        public GramPerCubicCentimeter(double value) : base(value) {}
    }
}
