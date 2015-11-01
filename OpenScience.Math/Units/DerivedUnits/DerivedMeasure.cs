using System;
using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Units.DerivedUnits
{
    public class DerivedMeasure<TUnitMeasure1, TUnitMeasure2, TDerivedUnit, TUnit1, TUnit2> : NumericValue<TDerivedUnit> , IDerivedMeasure
        where TDerivedUnit : DerivedUnit<TUnit1, TUnit2>, new() 
        where TUnit1 : IUnit, new()
        where TUnit2 : IUnit, new()
        where TUnitMeasure1 : NumericValue<TUnit1>, new()
        where TUnitMeasure2 : NumericValue<TUnit2>, new()
    {
        public TUnitMeasure1 UnitMeasure1 { get; private set; }
        public TUnitMeasure2 UnitMeasure2 { get; private set; }

        public DerivedMeasure()
        {
            UnitMeasure1 = new TUnitMeasure1();
            UnitMeasure2 = new TUnitMeasure2();
        }

        public DerivedMeasure(double value) : base(value)
        {
            UnitMeasure1 = new TUnitMeasure1();
            UnitMeasure2 = new TUnitMeasure2();
        }

        public override double ConversionFactor
        {
            get { return GetConversionFactor(); }
        }

        public override string Abbreviation
        {
            get { return GetAbbreviation(); }
        }

        public double GetConversionFactor()
        {
            var factor1 = UnitMeasure1.Unit is IDerivedMeasure ? ((IDerivedMeasure)UnitMeasure1.Unit).GetConversionFactor() : UnitMeasure1.ConversionFactor;
            var factor2 = UnitMeasure2.Unit is IDerivedMeasure ? ((IDerivedMeasure)UnitMeasure2.Unit).GetConversionFactor() : UnitMeasure2.ConversionFactor;
            return typeof(TDerivedUnit) == typeof(MultiplicativeUnit<TUnit1, TUnit2>)
                       ? factor1 * factor2
                       : factor1 / factor2;
        }

        public string GetAbbreviation()
        {
            var abbrev1 = UnitMeasure1.Unit is IDerivedMeasure ? ((IDerivedMeasure)UnitMeasure1.Unit).GetAbbreviation() : UnitMeasure1.Abbreviation;
            var abbrev2 = UnitMeasure2.Unit is IDerivedMeasure ? ((IDerivedMeasure)UnitMeasure2.Unit).GetAbbreviation() : UnitMeasure2.Abbreviation;
            var separator = typeof(TDerivedUnit) == typeof(MultiplicativeUnit<TUnit1, TUnit2>) ? '*' : '/';
            return String.Format("{0} {2} {1}", abbrev1, abbrev2, separator);
        }
    }
}
