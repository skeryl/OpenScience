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
        Velocity<NumericValue<Length>, NumericValue<Time>> Velocity { get; }
        Meter Length { get; }
        
        Temperature Temperature { get; }

        Volume<TLength> Volume<TLength>() where TLength : NumericValue<Length>, new();

        TMass GetMass<TMass>() where TMass : NumericValue<Mass>, new();
        IPhysicalObject SetMass(NumericValue<Mass> mass);

        PhysicalCoordinate<TLength> GetCoordinates<TLength>() where TLength : NumericValue<Length>, new();
        IPhysicalObject SetCoordinates<TLength>(PhysicalCoordinate<TLength> coordinates) where TLength : NumericValue<Length>, new();

        Coulomb GetCharge();
        IPhysicalObject SetCharge(Coulomb c);
    }
}
