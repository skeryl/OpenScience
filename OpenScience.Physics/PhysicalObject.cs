using OpenScience.Math.Coordinates;
using OpenScience.Math.Units;
using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.DerivedUnits.Electricity;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.TimeMeasures;
using OpenScience.Physics.Interface;

namespace OpenScience.Physics
{
    public class PhysicalObject : IPhysicalObject
    {
        public virtual NumericValue<Mass> Mass { get; set; }
        public virtual Volume<Meter> Volume { get; set; }
        public virtual Velocity<Meter, Second> Velocity { get; set; }
        public virtual Meter Length { get; set; }
        public virtual PhysicalCoordinate<Meter> Coordinates { get; set; }
        public Coulomb Charge { get; set; }
        public Temperature Temperature { get; set; }
    }
}
