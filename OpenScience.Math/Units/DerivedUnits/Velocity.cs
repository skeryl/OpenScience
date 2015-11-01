namespace OpenScience.Math.Units.DerivedUnits
{
    public class Velocity<TLength, TTime> : DerivedMeasure<TLength, TTime, DivisiveUnit<Length, Time>, Length, Time> 
        where TLength : NumericValue<Length>, new() 
        where TTime : NumericValue<Time>, new()
    {
        public Velocity(){}

        public Velocity(double value) : base(value) {}

        public Velocity<TOtherLength, TOtherTime> Convert<TOtherLength, TOtherTime>()
            where TOtherLength : NumericValue<Length>, new()
            where TOtherTime : NumericValue<Time>, new()

        {
            var other = new Velocity<TOtherLength, TOtherTime>();
            var conversionRatio = other.ConversionFactor / ConversionFactor;
            other.Value = Value * conversionRatio;
            return other;
        }

        public Acceleration<TLength, TTime> Divide(NumericValue<Time> time)
        {
            return new Acceleration<TLength, TTime>(this, time);
        }

        public static Acceleration<TLength, TTime> operator /(Velocity<TLength, TTime> velocity, NumericValue<Time> time)
        {
            return velocity.Divide(time);
        } 

    }
}
