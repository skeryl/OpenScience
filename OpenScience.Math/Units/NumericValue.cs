using System;
using System.Collections.Generic;
using System.Globalization;
using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.Interface;

namespace OpenScience.Math.Units
{
    public class NumericValue<TUnit> : INumericValue
        where TUnit : IUnit, new()
    {
        public double Value { get; set; }

        public TUnit Unit { get; private set; }

        public IUnit GetUnit()
        {
            return Unit;
        }

        public virtual double ConversionFactor { get; set; }

        public virtual string Abbreviation { get; set; }

        public NumericValue()
        {
            Unit = new TUnit();
        }

        public NumericValue(double value) : this()
        {
            Value = value;
        }

        public NumericValue<TUnit> Convert<TNumericValue>()
            where TNumericValue : NumericValue<TUnit>, new()
        {
            var other = new TNumericValue();
            var conversionRatio = other.ConversionFactor/ConversionFactor;
            other.Value = Value*conversionRatio;
            return other;
        }

        #region operators

        public static INumericValue operator *(NumericValue<TUnit> value, INumericValue other)
        {
            return value.Multiply(other);
        }

        public static INumericValue operator /(NumericValue<TUnit> value, INumericValue other)
        {
            return value.Divide(other);
        }

        public static NumericValue<TUnit> operator *(NumericValue<TUnit> value, double other)
        {
            return (NumericValue<TUnit>) value.Multiply(other);
        }

        public static NumericValue<TUnit> operator /(NumericValue<TUnit> value, double other)
        {
            return (NumericValue<TUnit>) value.Divide(other);
        }

        public static NumericValue<TUnit> operator +(NumericValue<TUnit> value, NumericValue<TUnit> other)
        {
            double conversionFactor = value.ConversionFactor / other.ConversionFactor;
            double val = value.Value + (other.Value * conversionFactor);
            return new NumericValue<TUnit>(val) { Abbreviation = value.Abbreviation, ConversionFactor = value.ConversionFactor, Unit = value.Unit };
        }

        public static NumericValue<TUnit> operator -(NumericValue<TUnit> value, NumericValue<TUnit> other)
        {
            double conversionFactor = value.ConversionFactor / other.ConversionFactor;
            double val = value.Value - (other.Value*conversionFactor);
            return new NumericValue<TUnit>(val) { Abbreviation = value.Abbreviation, ConversionFactor = value.ConversionFactor, Unit = value.Unit };
        }

        public static NumericValue<TUnit> operator +(NumericValue<TUnit> value, double other)
        {
            return (NumericValue<TUnit>) value.Add(other);
        }

        public static NumericValue<TUnit> operator -(NumericValue<TUnit> value, double other)
        {
            return (NumericValue<TUnit>) value.Subtract(other);
        }

        #endregion

        #region mathematical operations

        public INumericValue Multiply(INumericValue other)
        {
            var numericType = GetType();
            var otherNumericType = other.GetType();
            var unitType = Unit.GetType();
            var otherUnitType = other.GetUnit().GetType();
            var mulitiplicativeUnitType = typeof(MultiplicativeUnit<,>).MakeGenericType(unitType, otherUnitType);
            var derivedMeasureType = typeof(DerivedMeasure<,,,,>).MakeGenericType(numericType, otherNumericType, mulitiplicativeUnitType, unitType, otherUnitType);
            var result = (INumericValue) Activator.CreateInstance(derivedMeasureType);
            result.Value = Value * other.Value;
            return result;
        }

        public INumericValue Divide(INumericValue other)
        {
            var numericType = GetType();
            var otherNumericType = other.GetType();
            var unitType = Unit.GetType();
            var otherUnitType = other.GetUnit().GetType();
            var mulitiplicativeUnitType = typeof(DivisiveUnit<,>).MakeGenericType(unitType, otherUnitType);
            var derivedMeasureType = typeof(DerivedMeasure<,,,,>).MakeGenericType(numericType, otherNumericType, mulitiplicativeUnitType, unitType, otherUnitType);
            var result = (INumericValue)Activator.CreateInstance(derivedMeasureType);
            result.Value = Value / other.Value;
            return result;
        }

        public INumericValue Multiply(double value)
        {
            return new NumericValue<TUnit>(Value * value) { Abbreviation = Abbreviation, ConversionFactor = ConversionFactor, Unit = Unit };
        }

        public INumericValue Divide(double value)
        {
            return new NumericValue<TUnit>(Value / value) { Abbreviation = Abbreviation, ConversionFactor = ConversionFactor, Unit = Unit };
        }

        public INumericValue Add(double value)
        {
            return new NumericValue<TUnit>(Value + value) { Abbreviation = Abbreviation, ConversionFactor = ConversionFactor, Unit = Unit };
        }

        public INumericValue Subtract(double value)
        {
            return new NumericValue<TUnit>(Value - value) { Abbreviation = Abbreviation, ConversionFactor = ConversionFactor, Unit = Unit };
        }

        #endregion

        public override string ToString()
        {
            return String.Format("{0} {1}", Value.ToString(CultureInfo.InvariantCulture), Abbreviation);
        }

        #region equality overrides

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            var value = obj as NumericValue<TUnit>;
            if (value == null) 
                return false;
            return Equals(value);
        }

        protected bool Equals(NumericValue<TUnit> other)
        {
            return Value.Equals(other.Value) && (Unit.GetType() == other.Unit.GetType()) && ConversionFactor.Equals(other.ConversionFactor) && string.Equals(Abbreviation, other.Abbreviation);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Value.GetHashCode();
                hashCode = (hashCode * 397) ^ EqualityComparer<TUnit>.Default.GetHashCode(Unit);
                hashCode = (hashCode * 397) ^ ConversionFactor.GetHashCode();
                hashCode = (hashCode * 397) ^ (Abbreviation != null ? Abbreviation.GetHashCode() : 0);
                return hashCode;
            }
        }

        #endregion

    }
}