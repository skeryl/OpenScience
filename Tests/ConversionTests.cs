using System;
using NUnit.Framework;
using OpenScience.Math;
using OpenScience.Math.Units.DerivedUnits;
using OpenScience.Math.Units.DerivedUnits.DensityMeasures;
using OpenScience.Math.Units.DerivedUnits.VolumeMeasures;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Math.Units.TimeMeasures;

namespace Tests
{
    [TestFixture]
    public class ConversionTests
    {
        [Test]
        public void TestUnitConversion()
        {
            Velocity<Meter, Second> tenMetersPerSecond = new Meter(20) / new Second(2);
            Assert.AreEqual(10, tenMetersPerSecond.Value);

            Acceleration<Meter, Second> fiveMetersPerSecondPerSecond = tenMetersPerSecond / new Second(2);
            Assert.AreEqual(5, fiveMetersPerSecondPerSecond.Value);
        }
        
        [Test]
        public void BasicConversionTests()
        {
            var massOfEarth = new Kilogram(5.97219 * (Math.Pow(10, 24)));
            var grams = massOfEarth.Convert<Gram>();
            Assert.AreEqual(massOfEarth.Value, grams.Value / 1000);

            var volumeOfEarth = new CubicKilometer(1.08321 * (Math.Pow(10, 12)));
            var volumeInCubicMeters = volumeOfEarth.Convert<Meter>();
            Assert.LessOrEqual(volumeOfEarth.Value - volumeInCubicMeters.Value / 1000000000, 0.001);

            var density = new KilogramPerCubicMeter((massOfEarth / volumeOfEarth).Value);
            var densityInGramsPerCm = density.Convert<Gram, Centimeter>();
            Assert.AreEqual(densityInGramsPerCm.Value / density.Value, .001);
        }

        [Test]
        public void BasicMathTests()
        {
            var fiveGrams = new Gram(5);
            var tenGrams = fiveGrams * 2;
            Assert.AreEqual(tenGrams.Value, 10);

            var sevenGrams = new Gram(7);
            var twelveGrams = fiveGrams + sevenGrams;
            Assert.AreEqual(twelveGrams.Value, 12);
            Assert.IsTrue(twelveGrams.Unit.GetType() == fiveGrams.Unit.GetType());
            Assert.IsTrue(sevenGrams.Equals(twelveGrams - 5));

            var twoKilograms = new Kilogram(2);
            var result = twoKilograms + ((twelveGrams * 3) + 4);
            Assert.AreEqual(result.Value, 2.04);
            Assert.IsTrue(Math.Abs(result.ConversionFactor - twoKilograms.ConversionFactor) < Constants.Epsilon);
            Console.WriteLine(result);
        }
    }
}
