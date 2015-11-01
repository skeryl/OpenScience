namespace OpenScience.Math.Units.DerivedUnits
{
    public class Density<TMass, TLength> : DerivedMeasure<TMass, NumericValue<Volume<TLength>>, DivisiveUnit<Mass, Volume<TLength>>, Mass, Volume<TLength>>
        where TMass : NumericValue<Mass>, new()
        where TLength : NumericValue<Length>, new()
    {
        public TMass Mass { get; set; }

        public Density(){} 

        public Density(double value) : base(value){}

        public Density<TOtherMass, TOtherLength> Convert<TOtherMass, TOtherLength>()
            where TOtherMass : NumericValue<Mass>, new()
            where TOtherLength : NumericValue<Length>, new()
        {
            var other = new Density<TOtherMass, TOtherLength>();
            var conversionRatio = other.ConversionFactor/ConversionFactor;
            other.Value = Value*conversionRatio;
            return other;
        }

    }
}
