using OpenScience.Math.Units;
using OpenScience.Math.Units.MassMeasures;

namespace OpenScience.Physics
{
    public abstract class SolidObject : PhysicalObject
    {
        protected SolidObject() : this(new Kilogram(1)) { }
        protected SolidObject(NumericValue<Mass> mass) : base(mass) { }
    }
}
