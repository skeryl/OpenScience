using System.Collections.Generic;
using OpenScience.Math.Units;
using OpenScience.Math.Units.Interface;

namespace OpenScience.Physics.Interface
{
    public interface IPhysicalSystem
    {
        ICollection<IPhysicalObject> PhysicalObjects { get; }
        TMass GetTotalMass<TMass>() where TMass : NumericValue<Mass>, new();
    }
}
