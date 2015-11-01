using OpenScience.Math.Units.DerivedUnits.EnergyMeasures;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.DerivedUnits.Electricity
{
    public class Volt : DerivedMeasure<Joule, Coulomb, DivisiveUnit<MultiplicativeUnit<Force<Kilogram, Meter, Second>, Length>, MultiplicativeUnit<Current, Time>>, MultiplicativeUnit<Force<Kilogram, Meter, Second>, Length>, MultiplicativeUnit<Current, Time>>
    {
    }
}
