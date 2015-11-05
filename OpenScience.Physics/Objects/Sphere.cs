using System;
using OpenScience.Math.Coordinates;
using OpenScience.Math.Units;
using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;

namespace OpenScience.Physics.Objects
{
    public class Sphere : SolidObject
    {
        private NumericValue<Length> _radius;

        public Sphere() : this(new Meter(1), new Kilogram(1)) { }
        public Sphere(NumericValue<Length> radius) : this(radius, new Kilogram(1)) { }
        public Sphere(NumericValue<Length> radius, NumericValue<Mass> mass) : base(mass)
        {
            _radius = radius;
        }

        public override Volume<TLength> GetVolume<TLength>()
        {
            return new Volume<TLength>((4 / 3) * System.Math.PI * System.Math.Pow(_radius.Value, 3));
        }

        public TLength GetRadius<TLength>() where TLength : NumericValue<Length>, new()
        {
            return (TLength) _radius.Convert<TLength>();
        } 

        public void SetRadius(NumericValue<Length> radius)
        {
            _radius = radius;
        }

    }
}
