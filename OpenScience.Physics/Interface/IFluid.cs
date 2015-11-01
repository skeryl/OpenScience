using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenScience.Math.Units.DerivedUnits.Viscosity;

namespace OpenScience.Physics.Interface
{
    public interface IFluid : IPhysicalObject
    {
        Poiseuille Viscosity { get; }
    }
}
