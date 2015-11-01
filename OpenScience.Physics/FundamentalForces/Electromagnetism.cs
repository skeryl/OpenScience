using OpenScience.Math.Units;
using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.DerivedUnits.ForceMeasures;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Math.Units.TimeMeasures;
using OpenScience.Physics.Interface;

namespace OpenScience.Physics.FundamentalForces
{
    public class Electromagnetism
    {
        public static readonly double K = 8.9875517873681764*System.Math.Pow(10, 9);

        // N * m^2 / C^2
        public static readonly DerivedMeasure<NumericValue<Force<Kilogram, Meter, Second>>,NumericValue<MultiplicativeUnit<DivisiveUnit<Length,Current>,DivisiveUnit<Length,Current>>>,MultiplicativeUnit<Force<Kilogram, Meter, Second>,MultiplicativeUnit<DivisiveUnit<Length,Current>,DivisiveUnit<Length,Current>>>,Force<Kilogram, Meter, Second>,MultiplicativeUnit<DivisiveUnit<Length, Current>, DivisiveUnit<Length, Current>>> 
            CoulombsConstant = new DerivedMeasure<
                NumericValue<Force<Kilogram, Meter, Second>>,
                NumericValue<MultiplicativeUnit<DivisiveUnit<Length, Current>, DivisiveUnit<Length, Current>>>,
                MultiplicativeUnit<Force<Kilogram, Meter, Second>, MultiplicativeUnit<DivisiveUnit<Length, Current>, DivisiveUnit<Length, Current>>>,
                Force<Kilogram, Meter, Second>,
                MultiplicativeUnit<DivisiveUnit<Length, Current>, DivisiveUnit<Length, Current>>>(K);

        public static Newton ForceBetween(IPhysicalObject physicalObject, IPhysicalObject otherObject)
        {
            Meter distanceBetween = physicalObject.Coordinates.DistanceFrom(otherObject.Coordinates);
            var distanceSquared = new Meter(System.Math.Pow(distanceBetween.Value, 2));
            var chargeProduct = physicalObject.Charge.Multiply(otherObject.Charge);
            return new Newton((CoulombsConstant.Multiply(chargeProduct).Divide(distanceSquared)).Value);
        } 
    }
}
