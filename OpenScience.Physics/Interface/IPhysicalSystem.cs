using System.Collections.Generic;

namespace OpenScience.Physics.Interface
{
    public interface IPhysicalSystem
    {
        ICollection<IPhysicalObject> PhysicalObjects { get; }
    }
}
