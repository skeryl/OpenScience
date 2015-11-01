using OpenScience.Math.Coordinates;
using OpenScience.Math.Units;
using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.DerivedUnits.Electricity;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace OpenScience.Physics.Interface
{
    public interface IPhysicalObject
    {
        NumericValue<Mass> Mass { get; }
        Volume<Meter> Volume { get; } 
        Velocity<Meter, Second> Velocity { get; }
        Meter Length { get; }
        PhysicalCoordinate<Meter> Coordinates { get; }
        Coulomb Charge { get; }
        Temperature Temperature { get; }
    }
}
