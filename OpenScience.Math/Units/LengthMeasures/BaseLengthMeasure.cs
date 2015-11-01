using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Math.Units.LengthMeasures
{
    public abstract class BaseLengthMeasure : NumericValue<Length>
    {
        protected BaseLengthMeasure(double value) : base(value) {}
        protected BaseLengthMeasure() :base() {}

        public Velocity<TLength, TTime> Divide<TLength, TTime>(NumericValue<Time> time)
            where TTime : NumericValue<Time>, new()  
            where TLength : NumericValue<Length>, new()
        {
            return new Velocity<TLength, TTime>(Convert<TLength>().Value / time.Convert<TTime>().Value);
        }

        public static Velocity<Meter, Second> operator /(BaseLengthMeasure length, NumericValue<Time> time)
        {
            return length.Divide<Meter, Second>(time);
        }
    }
}
