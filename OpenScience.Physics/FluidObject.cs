using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenScience.Math.Units;
using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.DerivedUnits.Viscosity;
using OpenScience.Physics.Interface;

namespace OpenScience.Physics
{
    public class FluidObject : PhysicalObject, IFluid
    {
        public Poiseuille Viscosity { get; set; }

        public override Volume<TLength> Volume<TLength>()
        {
            throw new NotImplementedException();
        }
    }
}
