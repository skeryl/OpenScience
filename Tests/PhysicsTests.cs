using System;
using NUnit.Framework;
using OpenScience.Math.Coordinates;
using OpenScience.Math.Units.DerivedUnits.Electricity;
using OpenScience.Math.Units.DerivedUnits.ForceMeasures;
using OpenScience.Math.Units.LengthMeasures;
using OpenScience.Math.Units.MassMeasures;
using OpenScience.Physics;
using OpenScience.Physics.FundamentalForces;

namespace Tests
{
    [TestFixture]
    public class PhysicsTests
    {
        [Test]
        public void TestGravitation()
        {
            var earth = new PhysicalObject { Mass = new Kilogram(5.98 * (Math.Pow(10, 24))), Coordinates = new PhysicalCoordinate<Meter>(new Meter(0), new Meter(0), new Meter(6378100)) };

            var shaneOnGround = new PhysicalObject { Mass = new Kilogram(79.37), Coordinates = new PhysicalCoordinate<Meter>() };
            var shaneAtWork = new PhysicalObject { Mass = new Kilogram(79.37), Coordinates = new PhysicalCoordinate<Meter>(new Meter(0), new Meter(0), new Meter(-60)) };
            var shaneOnPlane = new PhysicalObject { Mass = new Kilogram(79.37), Coordinates = new PhysicalCoordinate<Meter>(new Meter(0), new Meter(0), new Meter(-11277.6)) };
            var halfwayToMoon = new PhysicalObject { Mass = new Kilogram(79.37), Coordinates = new PhysicalCoordinate<Meter>(new Meter(0), new Meter(0), new Meter(-192201500)) };
            
            var forceOnGround = Gravitation.GravityBetween(shaneOnGround, earth);
            var forceAtWork = Gravitation.GravityBetween(shaneAtWork, earth);
            Assert.Less(forceAtWork.Value, forceOnGround.Value);

            var forceOnPlane = Gravitation.GravityBetween(shaneOnPlane, earth);
            Assert.Less(forceOnPlane.Value, forceAtWork.Value);

            var forceHalfwayToMoon = Gravitation.GravityBetween(halfwayToMoon, earth);
            Assert.Less(forceHalfwayToMoon.Value, forceOnPlane.Value);
        }

        [Test]
        public void TestElectromagnetism()
        {
            var particleOne = new PhysicalObject { Charge = new Coulomb(1), Coordinates = new PhysicalCoordinate<Meter>(new Meter(), new Meter(), new Meter()) };
            var particleTwo = new PhysicalObject { Charge = new Coulomb(1), Coordinates = new PhysicalCoordinate<Meter>(new Meter(), new Meter(), new Meter(1)) };
            Newton forceBetween = Electromagnetism.ForceBetween(particleOne, particleTwo);
            Assert.AreEqual(8987551787.3681755, forceBetween.Value);
        }
    }
}
