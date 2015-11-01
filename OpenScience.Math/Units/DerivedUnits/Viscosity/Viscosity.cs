using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Units.DerivedUnits.Viscosity
{
    public class Viscosity<TMass, TLength, TTime>
        : DerivedMeasure<
            NumericValue<Force<TMass, TLength, TTime>>,
            NumericValue<MultiplicativeUnit<Time, Area<TLength>>>,
            DivisiveUnit<Force<TMass, TLength, TTime>,MultiplicativeUnit<Time, Area<TLength>>>,
            Force<TMass, TLength, TTime>,
            MultiplicativeUnit<Time, Area<TLength>>
        >, IUnit 
        where TMass : NumericValue<Mass>, new() 
        where TLength : NumericValue<Length>, new() 
        where TTime : NumericValue<Time>, new()
    {
        public Viscosity(double value) : base(value){}
        public Viscosity() : base() {}
    }
}
