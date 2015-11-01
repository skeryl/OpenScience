using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.DerivedUnits.Viscosity
{
    public class Poiseuille : Viscosity<Kilogram, Meter, Second>
    {
        public Poiseuille(double value) : base(value) { }
        public Poiseuille() : base() { }
    }
}
