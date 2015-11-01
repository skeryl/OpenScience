using System.Collections.Generic;
using OpenScience.Physics.Interface;

namespace OpenScience.Physics
{
    public class PhysicalSystem : IPhysicalSystem
    {
        public ICollection<IPhysicalObject> PhysicalObjects { get; private set; }

        public PhysicalSystem()
        {
            PhysicalObjects = new List<IPhysicalObject>();
        }

        public PhysicalSystem(params IPhysicalObject[] objects)
        {
            PhysicalObjects = new List<IPhysicalObject>(objects);
        }
    }
}
