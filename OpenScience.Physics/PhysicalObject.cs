using System;
using OpenScience.Math.Coordinates;
using OpenScience.Math.Units;
using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.DerivedUnits.Electricity;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Math.Units.TimeMeasures;
using OpenScience.Physics.Interface;

namespace OpenScience.Physics
{
    public abstract class PhysicalObject : IPhysicalObject
    {
        protected PhysicalCoordinate<Meter> Coordinates;
        protected NumericValue<Mass> Mass;
        protected Coulomb Charge;

        public virtual Velocity<NumericValue<Length>, NumericValue<Time>> Velocity { get; set; }
        public virtual Meter Length { get; set; }
        
        public Temperature Temperature { get; set; }

        protected PhysicalObject() : this(new Kilogram(1)) { }
        protected PhysicalObject(NumericValue<Mass> mass)
        {
            Mass = mass;
            Coordinates = PhysicalCoordinate<Meter>.Create(0, 0, 0);
            Charge = new Coulomb();
        }

        public abstract Volume<TLength> Volume<TLength>() where TLength : NumericValue<Length>, new();

        public TMass GetMass<TMass>() where TMass : NumericValue<Mass>, new()
        {
            return (TMass) Mass.Convert<TMass>();
        }

        public IPhysicalObject SetMass(NumericValue<Mass> mass)
        {
            Mass = mass;
            return this;
        }

        public PhysicalCoordinate<TLength> GetCoordinates<TLength>() where TLength : NumericValue<Length>, new()
        {
            return Coordinates.Convert<TLength>();
        }

        public IPhysicalObject SetCoordinates<TLength>(PhysicalCoordinate<TLength> coordinates) where TLength : NumericValue<Length>, new()
        {
            Coordinates = coordinates.Convert<Meter>();
            return this;
        }

        public Coulomb GetCharge()
        {
            return Charge;
        }

        public IPhysicalObject SetCharge(Coulomb c)
        {
            Charge = c;
            return this;
        }
    }
}
