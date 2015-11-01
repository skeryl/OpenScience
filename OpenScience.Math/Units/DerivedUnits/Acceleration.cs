using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Units.DerivedUnits
{
    public class Acceleration<TLength, TTime> : DerivedMeasure<TLength, TTime, DivisiveUnit<Length, Time>, Length, Time>, IUnit
        where TLength : NumericValue<Length>, new()
        where TTime : NumericValue<Time>, new()
    {
        public Acceleration(){}
        public Acceleration(double value) : base(value){}
        public Acceleration(Velocity<TLength, TTime> velocity, NumericValue<Time> time)
        {
            Value = velocity.Value/time.Convert<TTime>().Value;
        } 
    }
}
