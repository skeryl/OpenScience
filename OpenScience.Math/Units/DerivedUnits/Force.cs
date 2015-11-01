using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Units.DerivedUnits
{
    public class Force<TMass, TLength, TTime> : 
        DerivedMeasure<
            TMass, 
            NumericValue<Acceleration<TLength, TTime>>, 
            DivisiveUnit<Mass, Acceleration<TLength, TTime>>, 
            Mass, 
            Acceleration<TLength, TTime>
        >, IUnit
        where TMass : NumericValue<Mass>, new()
        where TLength : NumericValue<Length>, new()
        where TTime : NumericValue<Time>, new()
    {
        public Force() { }
        public Force(double value) : base(value) { }
    }
}
