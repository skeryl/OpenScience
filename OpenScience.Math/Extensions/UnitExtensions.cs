using OpenScience.Math.Units;
using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Extensions
{
    public static class UnitExtensions
    {
        public static INumericValue Simplify<TUnit>(this NumericValue<TUnit> numericValue) 
            where TUnit : BaseUnit, new()
        {
            return numericValue;
        }
    }
}
