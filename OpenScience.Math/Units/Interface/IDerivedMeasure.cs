namespace OpenScience.Math.Units.Interface
{
    public interface IDerivedMeasure : INumericValue
    {
        double GetConversionFactor();
        string GetAbbreviation();
    }
}
