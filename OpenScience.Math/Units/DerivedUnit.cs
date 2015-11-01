using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Units
{
    public abstract class DerivedUnit<TUnit1, TUnit2> : BaseUnit, IDerivedUnit
        where TUnit1 : IUnit, new() 
        where TUnit2 : IUnit, new()
    {
        public IUnit Unit1 { get; set; }

        public IUnit Unit2 { get; set; }

        protected DerivedUnit()
        {
            Unit1 = new TUnit1();
            Unit2 = new TUnit2();
        } 

        protected DerivedUnit(TUnit1 unit1, TUnit2 unit2)
        {
            Unit1 = unit1;
            Unit2 = unit2;
        } 

        //public abstract override string Abbreviation { get; }
    }
}