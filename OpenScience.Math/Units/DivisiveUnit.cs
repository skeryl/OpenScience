using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Units
{
    public class DivisiveUnit<TUnit1, TUnit2> : DerivedUnit<TUnit1, TUnit2>
        where TUnit1 : IUnit, new() 
        where TUnit2 : IUnit, new()
    {
        public DivisiveUnit() : base()
        {
        }

        public DivisiveUnit(TUnit1 unit1, TUnit2 unit2) : base(unit1, unit2)
        {
        }

    }
}