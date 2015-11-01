using System;
using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Units
{
    public abstract class BaseUnit : IUnit
    {
        public static IDerivedUnit operator *(BaseUnit unit, IUnit other)
        {
            var resultantType = typeof (MultiplicativeUnit<,>).MakeGenericType(unit.GetType(), other.GetType());
            return (IDerivedUnit) Activator.CreateInstance(resultantType);
        }

        public static IDerivedUnit operator /(BaseUnit unit, IUnit other)
        {
            var resultantType = typeof(DivisiveUnit<,>).MakeGenericType(unit.GetType(), other.GetType());
            return (IDerivedUnit) Activator.CreateInstance(resultantType);
        }

    }

    public sealed class Length : BaseUnit
    {
    }

    public sealed class Mass : BaseUnit
    {
    }

    public sealed class Time : BaseUnit
    {
    }

    public sealed class Current : BaseUnit
    {
    }

    public sealed class Temperature : BaseUnit
    {
    }

    public sealed class Mole : BaseUnit
    {
    }

    public sealed class Luminosity : BaseUnit
    {
    }
}
