using OpenScience.Math.Units;
using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.DerivedUnits.ForceMeasures;
using OpenScience.Math.Units.Interface;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Math.Units.TimeMeasures;
using OpenScience.Physics.Interface;

namespace OpenScience.Physics.FundamentalForces
{
    public class Gravitation
    {
        public static readonly double G = 6.673*System.Math.Pow(10, -11);
        
        // N·(m/kg)2
        public static readonly INumericValue GravitationalConstant =  new DerivedMeasure<
                NumericValue<Force<Kilogram, Meter, Second>>,
                NumericValue<MultiplicativeUnit<DivisiveUnit<Length,Mass>,DivisiveUnit<Length,Mass>>>,
                MultiplicativeUnit<Force<Kilogram, Meter, Second>, MultiplicativeUnit<DivisiveUnit<Length, Mass>, DivisiveUnit<Length, Mass>>>,
                Force<Kilogram, Meter, Second>,
                MultiplicativeUnit<DivisiveUnit<Length,Mass>,DivisiveUnit<Length,Mass>>>(G);

        // using Newton's Law of Universal Gravitation
        // http://en.wikipedia.org/wiki/Newton%27s_law_of_universal_gravitation

        public static Newton GravityBetween(IPhysicalObject physicalObject, IPhysicalObject otherObject)
        {
            Meter distanceBetween = physicalObject.GetCoordinates<Meter>().DistanceFrom<Meter>(otherObject.GetCoordinates<Meter>());
            var distanceSquared = new Meter(System.Math.Pow(distanceBetween.Value, 2));
            var productOfMasses = (physicalObject.GetMass<Kilogram>()*otherObject.GetMass<Kilogram>());
            return new Newton(GravitationalConstant.Multiply((productOfMasses).Divide(distanceSquared)).Value);
        }
    }
}
