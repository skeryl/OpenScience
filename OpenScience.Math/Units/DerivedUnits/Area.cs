using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Units.DerivedUnits
{
    public class Area<TLength> : DerivedMeasure<TLength, TLength, MultiplicativeUnit<Length, Length>, Length, Length>, IUnit
        where TLength : NumericValue<Length>, new()
    {
        public Area() {}

        public Area(double value) : base(value) {}
        
        public new Area<TOtherLength> Convert<TOtherLength>()
            where TOtherLength :  NumericValue<Length>, new()
        {
            var other = new Area<TOtherLength>();
            var conversionRatio = other.ConversionFactor / ConversionFactor;
            other.Value = Value * conversionRatio;
            return other;
        } 
    }
}
