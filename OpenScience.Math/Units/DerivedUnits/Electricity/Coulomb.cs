using OpenScience.Math.Units.CurrentMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.DerivedUnits.Electricity
{
    public class Coulomb : DerivedMeasure<Ampere, Second, MultiplicativeUnit<Current, Time>, Current, Time>
    {
        public Coulomb(){}
        public Coulomb(double value) { Value = value; }
    }
}
