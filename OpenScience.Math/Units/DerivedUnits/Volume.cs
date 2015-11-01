using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Units.DerivedUnits
{
    public class Volume<TLength> : DerivedMeasure<TLength, NumericValue<Area<TLength>>, MultiplicativeUnit<Length, Area<TLength>>, Length, Area<TLength>>, IUnit
        where TLength : NumericValue<Length>, new()
    {
        public Volume() : base() {}

        public Volume(double value) : base(value)
        {
        }

        public new TOther Convert<TOther, TOtherLength>()
            where TOtherLength : NumericValue<Length>, new()
            where TOther : Volume<TOtherLength>, new()
        {
            var other = new TOther();
            var conversionRatio = other.ConversionFactor / ConversionFactor;
            other.Value = Value * conversionRatio;
            return other;
        }

        public new Volume<TOtherLength> Convert<TOtherLength>()
            where TOtherLength : NumericValue<Length>, new()
        {
            var other = new Volume<TOtherLength>();
            var conversionRatio = other.ConversionFactor / ConversionFactor;
            other.Value = Value * conversionRatio;
            return other;
        }
    }
}
