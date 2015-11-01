using OpenScience.Math.Units.CurrentMeasures;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.DerivedUnits.Electricity
{
    public class Ohm : DerivedMeasure<
        Volt, 
        Ampere, 
        DivisiveUnit<DivisiveUnit<MultiplicativeUnit<Force<Kilogram, Meter, Second>, Length>, MultiplicativeUnit<Current, Time>>, Current>, 
        DivisiveUnit<MultiplicativeUnit<Force<Kilogram, Meter, Second>, Length>, MultiplicativeUnit<Current, Time>>, 
        Current>
    {
        public Ohm() { }
        public Ohm(double value) { Value = value; }
    }
}
