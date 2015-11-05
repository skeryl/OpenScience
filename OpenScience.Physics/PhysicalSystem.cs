using System.Collections.Generic;
using System.Linq;
using OpenScience.Math.Units;
using OpenScience.Math.Units.Interface;
using OpenScience.Physics.Interface;

namespace OpenScience.Physics
{
    public class PhysicalSystem : IPhysicalSystem
    {
        public ICollection<IPhysicalObject> PhysicalObjects { get; private set; }

        public TMass GetTotalMass<TMass>() where TMass : NumericValue<Mass>, new()
        {
            return new TMass { Value = PhysicalObjects.Sum(p => p.GetMass<TMass>().Value) };
        }

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
