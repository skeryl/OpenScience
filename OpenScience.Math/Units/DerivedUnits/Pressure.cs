namespace OpenScience.Math.Units.DerivedUnits
{
    public class Pressure<TFMass, TFLength, TFTime, TLength> : DerivedMeasure<NumericValue<Force<TFMass, TFLength, TFTime>>, TLength, DivisiveUnit<Force<TFMass, TFLength, TFTime>, Length>, Force<TFMass, TFLength, TFTime>, Length>
        where TFMass : NumericValue<Mass>, new()
        where TFLength : NumericValue<Length>, new()
        where TFTime : NumericValue<Time>, new()
        where TLength : NumericValue<Length>, new()
    {
        public Pressure() { }
        public Pressure(double value) : base(value) { }
    }
}
