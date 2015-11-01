using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.DerivedUnits.EnergyMeasures
{
    public class Joule : DerivedMeasure<NumericValue<Force<Kilogram, Meter, Second>>, Meter, MultiplicativeUnit<Force<Kilogram, Meter, Second>, Length>, Force<Kilogram, Meter, Second>, Length>
    {
        public Joule() { }
        public Joule(double value) { Value = value; }
    }
}
