namespace OpenScience.Math.Units.Interface
{
    public interface INumericValue
    {
        double Value { get; set; }
        IUnit GetUnit();
        double ConversionFactor { get; set; }
        string Abbreviation { get; set; }

        INumericValue Multiply(INumericValue other);
        INumericValue Divide(INumericValue other);

        INumericValue Multiply(double value);
        INumericValue Divide(double value);
        INumericValue Add(double value);
        INumericValue Subtract(double value);
    }
}